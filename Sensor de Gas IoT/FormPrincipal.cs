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

namespace Sensor_de_Gas_IoT {
    public partial class FormPrincipal : Form {
        public FormPrincipal() {
            InitializeComponent();
        }

        private void btnPanico_Click(object sender, EventArgs e) {
            int duracionAlarmaPanico = 1000;
            while (duracionAlarmaPanico-- > 0) {
                SystemSounds.Beep.Play();
            }
        }
    }
}
