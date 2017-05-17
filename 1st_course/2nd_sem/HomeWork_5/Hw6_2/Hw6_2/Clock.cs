using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw6_2
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClockTimer.Text = "Time: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void ClockTimer_Click(object sender, EventArgs e)
        {
        }

        private void Clock_Load(object sender, EventArgs e)
        {

        }
    }
}
