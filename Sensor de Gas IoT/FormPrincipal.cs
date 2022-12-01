using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
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
        private bool ventiladoresEncendidos = false;
        private bool notificacionEnviada = false;

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
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Cerrar el form
                Close();
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

        private void ProcesarDatosMQ3(object sender, EventArgs e) {
            DateTime now = DateTime.Now;
            logMq3.AppendText($"{now}->{arduinoData}");
            try {
                string[] data = arduinoData.Split(':');
                if (float.TryParse(data[1], out valorMQ3)) {
                    lblMq3.Text = $"MQ3: {valorMQ3} PPM";
                    if (valorMQ3 > 300) {
                        //Play Alarma.wav from /Resources folder
                        if (!alarmaLocalSonando) {
                            player.PlayLooping();
                            alarmaLocalSonando = true;
                        }
                        if (!ventiladoresEncendidos) {
                            ventilador.Visible = true;
                            ventiladoresEncendidos = true;
                            btnEnciendeAspersores.Text = "Apagar ventiladores";
                            //Enciende ventiladores en el Arduino
                            serialArduino.Write("1");
                        }
                        alcohol.Image = Image.FromFile($"{resources}\\WearMask.png");

                       /* if (!notificacionEnviada) {
                            notificacionEnviada = true;
                            hiloNotificacion = new Thread(()=> {
                                EnviarNotificacionCelular("Se detectó un alto nivel de alcoholes en el aire");
                            });
                            hiloNotificacion.Start();
                        }*/



                    } else if (valorMQ3 > 100 && valorMQ3 <= 300) {
                        alcohol.Image = Image.FromFile($"{resources}\\HumoMedium.png");
                        player.Stop();
                        alarmaLocalSonando = false;
                        notificacionEnviada = false;
                    } else {
                        alcohol.Image = Image.FromFile($"{resources}\\HumoLow.png");
                        player.Stop();
                        alarmaLocalSonando = false;
                        notificacionEnviada = false;
                    }
                
                } else {
                    lblMq3.Text = $"MQ3: 0 PPM";
                    notificacionEnviada = false;
                    alcohol.Image = Image.FromFile($"{resources}\\Okay.png");
                    player.Stop();

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
            DateTime now = DateTime.Now;
            logMq2.AppendText($"{now}->{arduinoData}");
            try {
                string[] data = arduinoData.Split(':');
                if (float.TryParse(data[1], out valorMQ2)) {
                    lblMq2.Text = $"MQ2: {valorMQ2} PPM";
                    if (valorMQ2 > 300) {
                        if (!alarmaLocalSonando) {
                            player.PlayLooping();
                            alarmaLocalSonando = true;
                        }
                        if (!ventiladoresEncendidos) {
                            ventilador.Visible = true;
                            btnEnciendeAspersores.Text = "Apagar ventiladores";
                            ventiladoresEncendidos = true;
                            //Enciende ventiladores en el Arduino
                            serialArduino.Write("1");
                        }
                        humo.Image = Image.FromFile($"{resources}\\HumoHigh.png");
                    } else if (valorMQ2 > 100 && valorMQ2 <= 300) {
                        humo.Image = Image.FromFile($"{resources}\\HumoMedium.png");
                    } else {
                        humo.Image = Image.FromFile($"{resources}\\HumoLow.png");
                    }
                } else {
                    lblMq2.Text = $"MQ2: 0 PPM";
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


        private void btnPanico_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Está seguro que desea activar el botón de pánico?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                SonarAlarma();
                MessageBox.Show("Se ha llamado a emergencias. Los ventiladores serán encendidos. Una notificación fue enviada a su celular.", "Confirmación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnviarNotificacionCelular($"Se ha activado el botón de pánico. Los ventiladores serán encendidos. " +
                    $"Ultimos valores del sensor MQ2: {valorMQ2} PPM | Ultimos valores del sensor MQ3: {valorMQ3} PPM. BOTON DE PÁNICO FUE ACTIVADO.");
                if (!ventiladoresEncendidos) {
                    ventilador.Visible = true;
                    btnEnciendeAspersores.Text = "Apagar ventiladores";
                    ventiladoresEncendidos = true;
                    //Enciende ventiladores en el Arduino
                    serialArduino.Write("1");
                }
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
            try {
                TwilioClient.Init(accountSid, authToken);
                var message = MessageResource.Create(
                    body: mensaje,
                    from: new Twilio.Types.PhoneNumber(Properties.Settings.Default.TwilioPhone),
                    to: new Twilio.Types.PhoneNumber(Properties.Settings.Default.TwilioTo)
                );
                if (message.Sid != null) {
                    MessageBox.Show("Se ha enviado una notificación a su celular.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show("No se pudo enviar la notificación a su celular.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e) {
            try {
                serialArduino.Write("0");
                serialArduino.Close();
            } catch {
                Console.WriteLine("[IGNORE]: Error al cerrar el puerto serial");
            }
        }

        private void btnEnciendeVentiladores_Click(object sender, EventArgs e) {
            if (!ventiladoresEncendidos) {
                ventilador.Visible = true;
                btnEnciendeAspersores.Text = "Apagar ventiladores";
                //Encender ventiladores en el arduino
                serialArduino.Write("1");
                ventiladoresEncendidos = true;
            } else {
                ventilador.Visible = false;
                btnEnciendeAspersores.Text = "Encender ventiladores";
                //Apagar ventiladores en el arduino
                serialArduino.Write("0");
                ventiladoresEncendidos = false;
            }
        }

        private void logMq2_TextChanged(object sender, EventArgs e) {
            logMq2.SelectionStart = logMq2.Text.Length;
            logMq2.ScrollToCaret();
        }

        private void logMq3_TextChanged(object sender, EventArgs e) {
            logMq3.SelectionStart = logMq3.Text.Length;
            logMq3.ScrollToCaret();
        }

        private void btnNotificarCelular_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Desea enviar un mensaje de alerta o los valores actuales de los sensores?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                EnviarNotificacionCelular($"Se ha activado el botón de pánico. Los ventiladores serán encendidos. Ultimos valores del sensor MQ2: {valorMQ2} PPM | Ultimos valores del sensor MQ3: {valorMQ3} PPM. Se reporta PELIGRO!");
            } else {
                EnviarNotificacionCelular("Se ha activado el botón de pánico. Los ventiladores serán encendidos.");
            }
        }

        #endregion
    }
}
