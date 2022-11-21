using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Sensor_de_Gas_IoT {
    public partial class FormPrincipal : Form {

        private SerialPort serialMQ2 = default;
        string resources = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Resources");
        SoundPlayer player = default;
        bool alarmaLocalSonando = false;
        public FormPrincipal() {
            InitializeComponent();
        }

        private void btnPanico_Click(object sender, EventArgs e) {  

        }

        private void FormPrincipal_Load(object sender, EventArgs e) {
            serialMQ2 = new SerialPort();
            player = new SoundPlayer { SoundLocation = $"{resources}\\Alarma.wav" };
        }

        private void btnEncenderAlarmaLocalmente_Click(object sender, EventArgs e) {
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
    }
}
