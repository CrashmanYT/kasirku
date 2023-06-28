using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasirku
{
    public partial class Kasirku : Form
    {
        public Kasirku()
        {
            InitializeComponent();
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            dateLbl.Text = $"Date : {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}";
            timeLbl.Text = $"Time : {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
        }
    }
}
