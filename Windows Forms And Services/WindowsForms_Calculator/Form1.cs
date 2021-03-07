using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            input1.Text = "0";
            input2.Text = "0";
        }
        

        private void btn(object sender, EventArgs e)
        {
            string n = input1.Text;
            string n2 = input2.Text;
            Regex regex = new Regex("^[0-9]+$");
           
            if (regex.IsMatch(n) && regex.IsMatch(n2))
            {
                int num1 = Convert.ToInt32(input1.Text);
                int num2 = Convert.ToInt32(input2.Text);
                var result = 0;
                if (Addition.Checked)
                {
                    result = num1 + num2;
                }
                else if (Subtraction.Checked)
                {
                    result = num1 - num2;
                }
                else if (Multiplication.Checked)
                {
                    result = num1 * num2;
                }
                else if (Division.Checked)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot Divide by Zero");
                        Environment.Exit(0);
                    }
                    result = num1 / num2;
                }
                else
                {
                    MessageBox.Show("Please Select An Operation");
                    Environment.Exit(0);
                }
                MessageBox.Show("Result="result.ToString());
            }
            else
            {
                MessageBox.Show("Please enter valid input for the operands");
            }
        }
        private void btn1(object sender, EventArgs e)
        {
            input1.Text = "";
        }
        private void btn2(object sender, EventArgs e)
        {
            input2.Text = "";
        }
    }
}
