using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Led_GUI_Extention
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RedLedBTN_Click(object sender, EventArgs e)
        {
            RedLed.Checked = !RedLed.Checked;
        }

        private void GreenLedBTN_Click(object sender, EventArgs e)
        {
            GreenLed.Checked = !GreenLed.Checked;
        }

        private void BlueLedBTN_Click(object sender, EventArgs e)
        {
            BlueLed.Checked = !BlueLed.Checked;
        }
    }
}
