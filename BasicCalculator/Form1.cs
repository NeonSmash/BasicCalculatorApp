using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        private double firstOperand = 0;
        private double secondOperand = 0;
        private string currentOperator = "";
        private bool isOperatorClicked = false;
        public Form1()
        {
            InitializeComponent();

            

    }

    private void button1_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                txtDisplay.Text = "1";
                isOperatorClicked = false;
            }
            else
            {
                txtDisplay.Text += "1";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtDisplay.Text, out firstOperand))
            {
                currentOperator = "+";
                isOperatorClicked = true;
            }
            else
            {
                // Handle the error, maybe clear the text or show an error message
                txtDisplay.Text = "0";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                txtDisplay.Text = "2";
                isOperatorClicked = false;
            }
            else
            {
                txtDisplay.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                txtDisplay.Text = "3";
                isOperatorClicked = false;
            }
            else
            {
                txtDisplay.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                txtDisplay.Text = "4";
                isOperatorClicked = false;
            }
            else
            {
                txtDisplay.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                txtDisplay.Text = "5";
                isOperatorClicked = false;
            }
            else
            {
                txtDisplay.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                txtDisplay.Text = "6";
                isOperatorClicked = false;
            }
            else
            {
                txtDisplay.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                txtDisplay.Text = "7";
                isOperatorClicked = false;
            }
            else
            {
                txtDisplay.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                txtDisplay.Text = "8";
                isOperatorClicked = false;
            }
            else
            {
                txtDisplay.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                txtDisplay.Text = "9";
                isOperatorClicked = false;
            }
            else
            {
                txtDisplay.Text += "9";
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out secondOperand))
            {
                switch (currentOperator)
                {
                    case "+":
                        txtDisplay.Text = (firstOperand + secondOperand).ToString();
                        break;
                    case "-":
                        txtDisplay.Text = (firstOperand - secondOperand).ToString();
                        break;
                    case "*":
                        txtDisplay.Text = (firstOperand * secondOperand).ToString();
                        break;
                    case "/":
                        txtDisplay.Text = secondOperand != 0 ? (firstOperand / secondOperand).ToString() : "Error";
                        break;
                }
                isOperatorClicked = false;
            }
            else
            {
                txtDisplay.Text = "0";
            }
        }

        private void substract_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out firstOperand))
            {
                currentOperator = "-";
                isOperatorClicked = true;
            }
            else
            {
                // Handle the error, maybe clear the text or show an error message
                txtDisplay.Text = "0";
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out firstOperand))
            {
                currentOperator = "/";
                isOperatorClicked = true;
            }
            else
            {
                // Handle the error, maybe clear the text or show an error message
                txtDisplay.Text = "0";
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out firstOperand))
            {
                currentOperator = "*";
                isOperatorClicked = true;
            }
            else
            {
                // Handle the error, maybe clear the text or show an error message
                txtDisplay.Text = "0";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked)
            {
                txtDisplay.Text = "0";
                isOperatorClicked = false;
            }
            else
            {
                txtDisplay.Text += "0";
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    button0.PerformClick();
                    txtDisplay.Focus();
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    button1.PerformClick();
                    txtDisplay.Focus();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    button2.PerformClick();
                    txtDisplay.Focus();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    button3.PerformClick();
                    txtDisplay.Focus();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    button4.PerformClick();
                    txtDisplay.Focus();
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    button5.PerformClick();
                    txtDisplay.Focus();
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    button6.PerformClick();
                    txtDisplay.Focus();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    button7.PerformClick();
                    txtDisplay.Focus();
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    button8.PerformClick();
                    txtDisplay.Focus();
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    button9.PerformClick();
                    txtDisplay.Focus();
                    break;
                case Keys.Add:
                case Keys.Oemplus: // Plus key
                    add.PerformClick();
                    txtDisplay.Focus();
                    break;
                case Keys.Subtract:
                case Keys.OemMinus: // Minus key
                    substract.PerformClick();
                    txtDisplay.Focus();
                    break;
                case Keys.Multiply:
                    multiply.PerformClick();
                    txtDisplay.Focus();
                    break;
                case Keys.Divide:
                    divide.PerformClick();
                    txtDisplay.Focus();
                    break;
                case Keys.Enter:
                    result.PerformClick();
                    txtDisplay.Focus();
                    break;
                
            }
            // To prevent the default behavior (like a button gaining focus)
            e.Handled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = "";
            isOperatorClicked = false;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplay.Text))
            {
                txtDisplay.Text = "0.";
            }
            else if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }


    }
}
