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
    /// <summary>
    /// Форма:Калькулятор
    /// </summary>
    public partial class Calculator : Form
    {
        private StackCalc calc = new StackCalc();

        private bool isCalculated = false;

        public Calculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Цифровая кнопка
        /// </summary>
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            if(isCalculated)
            {
                label1.Text = "";
                isCalculated = false;
            }

            var button = sender as Button;
            label1.Text += button.Text;
        }              
            
        /// <summary>
        /// Кнопка =
        /// </summary>
        private void buttonResult_Click(object sender, EventArgs e)
        {
            calc.AddValueToStack(Convert.ToDouble(label1.Text));
            calc.Calculation();
            label1.Text = Convert.ToString(calc.GetAnswer());
            calc.Clean();
            isCalculated = true;
        }       

        /// <summary>
        /// Кнопка ,
        /// </summary>
        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (label1.Text.IndexOf(',') != -1)
            {
                return;
            }
            label1.Text = label1.Text + ',';
        }

        /// <summary>
        /// Кнопка операции
        /// </summary>
        private void buttonOperation_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (label1.Text == "" && button.Text == "-")
            {
                label1.Text = label1.Text + '-';
                return;
            }

            if (label1.Text == "")
            {
                return;
            }

            calc.AddValueToStack(Convert.ToDouble(label1.Text));
            calc.AddOperationToStack(button.Text[0]);
            label1.Text = "";
        }
       
        /// <summary>
        /// Кнопка Del
        /// </summary>
        private void buttonDel_Click(object sender, EventArgs e)
        {
            calc.Clean();
            label1.Text = "";
        }

        /// <summary>
        /// Кнопка backspace
        /// </summary>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
