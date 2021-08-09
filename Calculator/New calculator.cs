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
    public partial class New_calculator : Form
    {
        public New_calculator()
        {
            InitializeComponent();
        }

        string operation = "";
        decimal old = 0;

        private void setvalue (Button data)
        {
            if (maintext.Text == "+" || maintext.Text == "*" || maintext.Text == "-" || maintext.Text == "/")
            {
                maintext.Text = "";

            }
            Button button = data;
            maintext.Text = maintext.Text + button.Text;
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            setvalue(button);
        }

        private void operator_click(object sender, EventArgs e)
        {

            string cur = maintext.Text;
            old = Convert.ToDecimal(cur);

            string oper = "+";
            maintext.Text = oper;
            operation = oper;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string cur = maintext.Text;
            old = Convert.ToDecimal(cur);

            string oper = "-";
            maintext.Text = oper;
            operation = oper;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string cur = maintext.Text;
            old = Convert.ToDecimal(cur);

            string oper = "*";
            maintext.Text = oper;
            operation = oper;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string cur = maintext.Text;
            old = Convert.ToDecimal(cur);

            string oper = "/";
            maintext.Text = oper;
            operation = oper;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string recent = maintext.Text;
            decimal recent_val = Convert.ToDecimal(recent);

            switch(operation)
            {
                case "+":
                    decimal added = old + recent_val;
                    old = added;
                    maintext.Text = added.ToString();
                    break;
                case "-":
                    decimal subbed = old - recent_val;
                    old = subbed;
                    maintext.Text = subbed.ToString();
                    break;
                case "*":
                    decimal product = old * recent_val;
                    old = product;
                    maintext.Text = product.ToString();
                    break;
                case "/":
                    if(recent_val == 0)
                    {
                        MessageBox.Show("CAN'T DIVIDE BY ZERO(0)");
                    }
                    else
                    {
                        decimal divided = old / recent_val;
                        old = divided;
                        maintext.Text = divided.ToString();
                       

                    }
                    break;

            }
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            old = 0;
            maintext.Text = "";
            operation = "";
        }
    }
}
