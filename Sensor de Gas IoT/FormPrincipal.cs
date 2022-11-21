using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Sensor_de_Gas_IoT {
    public partial class FormPrincipal : Form {

        private SerialPort serialArduino = default;
        private readonly string resources = Path.Combine(Path.GetFullPath(@"..\..\"), "Resources");
        private SoundPlayer player = default;
        private bool alarmaLocalSonando = false;
        private string arduinoData;
        float valorMQ3 = 0.0f, valorMQ2 = 0.0f;


        public FormPrincipal() {
            InitializeComponent();
        }

        #region Acciones de los botones

        private void FormPrincipal_Load(object sender, EventArgs e) {
            //Get settings from App.Config file
            string portName = Properties.Settings.Default.PortName;
            int baudRate = Properties.Settings.Default.BaudRate;
            serialArduino = new SerialPort {
                BaudRate = baudRate,
                PortName = portName
            };
            serialArduino.DataReceived += SerialMQ2_DataReceived;
            player = new SoundPlayer { SoundLocation = $"{resources}\\Alarma.wav" };


            //Open the port
            try {
                serialArduino.Open();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            chartSensorMQ3.ChartAreas[0].AxisX.Title = "Fecha";
            chartSensorMQ3.ChartAreas[0].AxisY.Title = "PPM";

            chartSensorMQ2.ChartAreas[0].AxisX.Title = "Fecha";
            chartSensorMQ2.ChartAreas[0].AxisY.Title = "PPM";

        }

        private void SerialMQ2_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            arduinoData = serialArduino.ReadLine();

            if (arduinoData.Contains("MQ2")) {
                Invoke(new EventHandler(ProcesarDatosMQ2));
            } else if (arduinoData.Contains("MQ3")) {
                Invoke(new EventHandler(ProcesarDatosMQ3));
            }

        }

        private void DetenerAlarmaEnMQ3() {
            if (alarmaLocalSonando) {
                player.Stop();
                alarmaLocalSonando = false;
            }
        }

        private void ProcesarDatosMQ3(object sender, EventArgs e) {
            logMq3.AppendText(arduinoData);
            try {
                //Check if arduinoData is a float: if true, compare its value to 300
                string[] data = arduinoData.Split(':');

                if (float.TryParse(data[1], out valorMQ3)) {
                    if (valorMQ3 > 300) {
                        if (!alarmaLocalSonando) {
                            alarmaLocalSonando = true;
                        }
                        alcohol.Image = Image.FromFile($"{resources}\\HumoHigh.png");
                    } else if (valorMQ3 > 100 && valorMQ3 <= 300) {
                        DetenerAlarmaEnMQ3();
                        alcohol.Image = Image.FromFile($"{resources}\\HumoMedium.png");
                        Console.Beep();
                        Console.Beep();
                    } else {
                        DetenerAlarmaEnMQ3();
                        alcohol.Image = Image.FromFile($"{resources}\\HumoLow.png");
                        Console.Beep();
                    }
                } else {
                    if (alarmaLocalSonando) {
                        player.Stop();
                        alarmaLocalSonando = false;
                    }
                    alcohol.Image = Image.FromFile($"{resources}\\Okay.png");
                }

                try {
                    if (serialArduino.IsOpen) {
                        chartSensorMQ3.Invoke((MethodInvoker)(() => {
                            chartSensorMQ3.Series["MQ3"].Points.AddXY(DateTime.Now.ToLongTimeString(), valorMQ3);
                        }));
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } catch {
                Console.WriteLine("[IGNORE]: Error de lectura del arduino");
            }
        }

        private void ProcesarDatosMQ2(object sender, EventArgs e) {
            logMq2.AppendText(arduinoData);
            //Check if arduinoData is a float: if true, compare its value to 300
            try {
                string[] data = arduinoData.Split(':');
                if (float.TryParse(data[1], out valorMQ2)) {
                    if (valorMQ2 > 300) {
                        if (!alarmaLocalSonando) {
                            alarmaLocalSonando = true;
                        }
                        humo.Image = Image.FromFile($"{resources}\\HumoHigh.png");
                    } else if (valorMQ2 > 100 && valorMQ2 <= 300) {
                        DetenerAlarmaEnMQ3();
                        humo.Image = Image.FromFile($"{resources}\\HumoMedium.png");
                        Console.Beep();
                        Console.Beep();
                    } else {
                        DetenerAlarmaEnMQ3();
                        humo.Image = Image.FromFile($"{resources}\\HumoLow.png");
                        Console.Beep();
                    }
                } else {
                    if (alarmaLocalSonando) {
                        player.Stop();
                        alarmaLocalSonando = false;
                    }
                    humo.Image = Image.FromFile($"{resources}\\Okay.png");
                }

                try {
                    if (serialArduino.IsOpen) {
                        chartSensorMQ2.Invoke((MethodInvoker)(() => {
                            chartSensorMQ2.Series["MQ2"].Points.AddXY(DateTime.Now.ToLongTimeString(), valorMQ2);
                        }));
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch {
                Console.Write("[IGNORE]: Error de lectura de arduino");
            }
        }

        private void btnEncenderAlarmaLocalmente_Click(object sender, EventArgs e) {
            SonarAlarma();
        }

        private void btnPanico_Click(object sender, EventArgs e) {
            // Prompt a message to confirm, if user confirms, send a message to the Arduino to turn on the buzzer
            if (MessageBox.Show("¿Está seguro que desea activar el botón de pánico?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                SonarAlarma();
                MessageBox.Show("Se ha llamado a emergencias. Los aspersores serán encendidos. Una notificación fue enviada a su celular.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnviarNotificacionCelular($"Se ha activado el botón de pánico. Los aspersores serán encendidos. Ultimos valores del sensor MQ2: {valorMQ2} PPM | Ultimos valores del sensor MQ3: {valorMQ3}. BOTON DE PÁNICO FUE ACTIVADO.");
            }
        }

        #endregion

        #region Eventos manuales

        private void SonarAlarma() {
            if (alarmaLocalSonando) {
                player.Stop();
                alarmaLocalSonando = false;
            } else {
                player.PlayLooping();
                alarmaLocalSonando = true;
            }
        }

        #endregion


        #region Notificaciones móviles

        private void EnviarNotificacionCelular(string mensaje = "PELIGRO") {
            string accountSid = Properties.Settings.Default.TwilioSid;
            string authToken = Properties.Settings.Default.TwilioAuthToken;
            TwilioClient.Init(accountSid, authToken);
            var message = MessageResource.Create(
                body: mensaje,
                from: new Twilio.Types.PhoneNumber(Properties.Settings.Default.TwilioPhone),
                to: new Twilio.Types.PhoneNumber(Properties.Settings.Default.TwilioTo)
            );
            //Check if message was sent
            if (message.Sid != null) {
                MessageBox.Show("Se ha enviado una notificación a su celular.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("No se pudo enviar la notificación a su celular.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e) {
            try {
                serialArduino.Close();
            } catch {
                Console.WriteLine("[IGNORE]: Error al cerrar el puerto serial");
            }
        }

        private void btnNotificarCelular_Click(object sender, EventArgs e) {
            //Prompt user if want to send Mq2 and mq3 values via SMS or just sms an alert
            if (MessageBox.Show("¿Desea enviar un mensaje de alerta o los valores actuales de los sensores?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                EnviarNotificacionCelular($"Se ha activado el botón de pánico. Los aspersores serán encendidos. Ultimos valores del sensor MQ2: {valorMQ2} PPM | Ultimos valores del sensor MQ3: {valorMQ3}. Se reporta PELIGRO!");
            } else {
                EnviarNotificacionCelular("Se ha activado el botón de pánico. Los aspersores serán encendidos.");
            }
        }

        #endregion
    }
}
