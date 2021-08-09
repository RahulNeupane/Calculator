using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        string operation = "";
        decimal old_value = 0;

        private void setvalue(string data)
        {
            if (maintext.Text == "+" || maintext.Text == "-" || maintext.Text == "*" || maintext.Text == "/")
            {
                maintext.Text = "";
            }
            string number = data;
            maintext.Text = maintext.Text + number;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            setvalue("6");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            setvalue("1");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            setvalue("2");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            setvalue("3");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            setvalue("4");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            setvalue("5");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setvalue("7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setvalue("8");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setvalue("9");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            setvalue("0");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string number = ".";
            maintext.Text = maintext.Text + number;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string current_val = maintext.Text;
            old_value = Convert.ToDecimal(current_val);

            string oper = "+";
            maintext.Text = oper;
            operation = oper;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string current_val = maintext.Text;
            old_value = Convert.ToDecimal(current_val);

            string oper = "-";
            maintext.Text = oper;
            operation = oper;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string current_val = maintext.Text;
            old_value = Convert.ToDecimal(current_val);

            string oper = "*";
            maintext.Text = oper;
            operation = oper;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string current_val = maintext.Text;
            old_value = Convert.ToDecimal(current_val);

            string oper = "/";
            maintext.Text = oper;
            operation = oper;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string new_val = maintext.Text;
            decimal new_value = Convert.ToDecimal(new_val);

            switch(operation)
            {
                case "+":
                    decimal added_value = old_value + new_value;
                    old_value = added_value;
                    maintext.Text = added_value.ToString();
                    break;
                case "-":
                    decimal subbed_value = old_value - new_value;
                    old_value = subbed_value;
                    maintext.Text = subbed_value.ToString();
                    break;
                case "*":
                    decimal multiplied_value = old_value * new_value;
                    old_value = multiplied_value;
                    maintext.Text = multiplied_value.ToString();
                    break;
                case "/":
                    if (new_value > 0 || new_value < 0)
                    {
                        decimal divided_value = old_value / new_value;
                        old_value = divided_value;
                        maintext.Text = divided_value.ToString();

                    }

                    else
                        MessageBox.Show("Divide by zero error");
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            old_value = 0;
            maintext.Text = "";
            operation = "";
        }

        

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_calculator calc = new New_calculator();
            calc.ShowDialog();
            this.Show();
        }
    }
}
