using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw6_1
{
    public partial class Form1 : Form
    {
        private StackCalc calc = new StackCalc();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + '7';
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + '9';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
            {
                button13_Click(sender, e);
                return;
            }

            if (e.KeyChar == '-')
            {
                button14_Click(sender, e);
                return;
            }

            if (e.KeyChar == '*')
            {
                button15_Click(sender, e);
                return;
            }

            if (e.KeyChar == '/')
            {
                button16_Click(sender, e);
                return;
            }

            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }

            if((e.KeyChar == '.'))
            {
                e.KeyChar = ',';
            }

            if(e.KeyChar == ',')
            {
                if(label1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if(Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    button10_Click(sender, e);
                }
                return;
            }
            e.Handled = true;
        }

        /// <summary>
        /// Кнопка =
        /// </summary>
        private void button10_Click(object sender, EventArgs e)
        {
            calc.AddValueToStack(Convert.ToDouble(label1.Text));
            calc.Calculation();
            label1.Text = Convert.ToString(calc.GetAnswer());
            calc.Clean();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + '1';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + '0';
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text = label1.Text + '2';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + '3';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + '5';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + '6';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + '8';
        }

        /// <summary>
        /// Кнопка ,
        /// </summary>
        private void button17_Click(object sender, EventArgs e)
        {
            if (label1.Text.IndexOf(',') != -1)
            {
                return;
            }
            label1.Text = label1.Text + ',';
        }

        /// <summary>
        /// Кнопка +
        /// </summary>
        private void button13_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                return;
            }
            calc.AddValueToStack(Convert.ToDouble(label1.Text));
            calc.AddOperationToStack('+');
            label1.Text = "";
        }

        /// <summary>
        /// Кнопка -
        /// </summary>
        private void button14_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                label1.Text = label1.Text + '-';
            }
            else
            {
                calc.AddValueToStack(Convert.ToDouble(label1.Text));
                calc.AddOperationToStack('-');
                label1.Text = "";
            }
        }

        /// <summary>
        /// Кнопка *
        /// </summary>
        private void button15_Click(object sender, EventArgs e)
        {
            if(label1.Text == "")
            {
                return;
            }
            calc.AddValueToStack(Convert.ToDouble(label1.Text));
            calc.AddOperationToStack('*');
            label1.Text = "";
        }

        /// <summary>
        /// Кнопка /
        /// </summary>
        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                return;
            }
            calc.AddValueToStack(Convert.ToDouble(label1.Text));
            calc.AddOperationToStack('/');
            label1.Text = "";
        }

        /// <summary>
        /// Кнопка Del
        /// </summary>
        private void button12_Click(object sender, EventArgs e)
        {
            calc.Clean();
            label1.Text = "";
        }

        /// <summary>
        /// Кнопка backspace
        /// </summary>
        private void button11_Click_1(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
