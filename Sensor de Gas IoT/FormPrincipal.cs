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

        private SerialPort serialMQ2 = default;
        private readonly string resources = Path.Combine(Path.GetFullPath(@"..\..\"), "Resources");
        private SoundPlayer player = default;
        private bool alarmaLocalSonando = false;
        private string arduinoData;
        float valorMQ2 = 0.0f;

        public FormPrincipal() {
            InitializeComponent();
        }

        #region Acciones de los botones

        private void FormPrincipal_Load(object sender, EventArgs e) {
            //Get settings from App.Config file
            string portName = Properties.Settings.Default.PortName;
            int baudRate = Properties.Settings.Default.BaudRate;
            serialMQ2 = new SerialPort {
                BaudRate = baudRate,
                PortName = portName
            };
            serialMQ2.DataReceived += SerialMQ2_DataReceived;
            player = new SoundPlayer { SoundLocation = $"{resources}\\Alarma.wav" };


            //Open the port
            try {
                serialMQ2.Open();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Thread hiloMQ2 = new Thread(LlenarGraficaSensorMQ2);
            hiloMQ2.Start();
            
        }

        private void SerialMQ2_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            arduinoData = serialMQ2.ReadLine();
            Invoke(new EventHandler(ProcesarDatos));
        }

        private void ProcesarDatos(object sender, EventArgs e) {
            logMq3.AppendText(arduinoData);
        }

        private void btnEncenderAlarmaLocalmente_Click(object sender, EventArgs e) {
            SonarAlarma();
        }

        private void btnPanico_Click(object sender, EventArgs e) {
            // Prompt a message to confirm, if user confirms, send a message to the Arduino to turn on the buzzer
            if (MessageBox.Show("¿Está seguro que desea activar el botón de pánico?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                SonarAlarma();
                MessageBox.Show("Se ha llamado a emergencias. Los aspersores serán encendidos. Una notificación fue enviada a su celular.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnviarNotificacionCelular($"Se ha activado el botón de pánico. Los aspersores serán encendidos. Ultimos valores del sensor MQ2: {valorMQ2} PPM.");
            } 
        }

        #endregion

        #region Eventos manuales

        private void SonarAlarma() {
            if (alarmaLocalSonando) {
                player.Stop();
                alarmaLocalSonando = false;
                btnEncenderAlarmaLocalmente.Text = "Encender Alarma Localmente";
            } else {
                player.Play();
                alarmaLocalSonando = true;
                btnEncenderAlarmaLocalmente.Text += " (SONANDO) ";
            }
        }

        #endregion

        #region Llenar graficas de valores

        private void LlenarGraficaSensorMQ2() {
            /*while (true) {
                try {
                    if (serialMQ2.IsOpen) {
                        string inData = serialMQ2.ReadLine();
                        int valor = int.Parse(inData);
                        chartSensorMQ2.Series["PPM"].Points.AddY(valor);
                        if (chartSensorMQ2.Series["PPM"].Points.Count > 100) {
                            chartSensorMQ2.Series["PPM"].Points.RemoveAt(0);
                        }
                        
                    }
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }

        #endregion

        #region Notificaciones móviles

        private void EnviarNotificacionCelular(string mensaje = "PELIGRO") {
            string accountSid = Properties.Settings.Default.TwilioSid;
            string authToken = Properties.Settings.Default.TwilioAuthToken;
            TwilioClient.Init(accountSid, authToken);
            var message = MessageResource.Create(
                body: mensaje,
                from: new Twilio.Types.PhoneNumber("+19498284783"),
                to: new Twilio.Types.PhoneNumber("+528672110473")
            );
            //Check if message was sent
            if (message.Sid != null) {
                MessageBox.Show("Se ha enviado una notificación a su celular.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("No se pudo enviar la notificación a su celular.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNotificarCelular_Click(object sender, EventArgs e) {
            EnviarNotificacionCelular("ALERTA: Pulsaron la alarma de notificación. Abra la aplicación para revisar las gráficas o revise sensores. PELIGRO.");
        }

        #endregion
    }
}
