using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace Calculator
{
    public partial class Calc_Form : Form
    {
        public Calc_Form()
        {
            InitializeComponent();
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            Output.Text += "1";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            Output.Text += "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            Output.Text += "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            Output.Text += "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            Output.Text += "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            Output.Text += "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            Output.Text += "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            Output.Text += "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            Output.Text += "9";
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            Output.Text += "0";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            int len = Output.Text.Length;
            if (Output.Text[--len] != '.')
            {
                Output.Text += ".";
            }
        }

        private void Cbut_Click(object sender, EventArgs e)
        {
            Output.Text = "";
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            Output.Text += "+";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Output.Text += "-";
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            Output.Text += "*";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            Output.Text += "/";
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Sqrt(Double.Parse(Output.Text));
                Output.Text = ans.ToString();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void Pow_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Pow(Double.Parse(Output.Text), 2);
                Output.Text = ans.ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Calc = new DataTable();
                var ans = Calc.Compute(Output.Text, "");
                Output.Text = ans.ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
