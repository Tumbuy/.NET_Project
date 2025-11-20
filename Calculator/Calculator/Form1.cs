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
    public partial class Main : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Main()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {


            if ((txtResult.Text == "0") || (isOperationPerformed))
                txtResult.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ",")
            {
                if (!txtResult.Text.Contains(","))
                    txtResult.Text = txtResult.Text + button.Text;
            }

            else
            {
                txtResult.Text = txtResult.Text + button.Text;
            }

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                btnEqual.PerformClick();
                operationPerformed = button.Text;
                label1.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(txtResult.Text);
                label1.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            resultValue = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    txtResult.Text = (resultValue + Double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (resultValue - Double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (resultValue * Double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (resultValue / Double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(txtResult.Text);
            label1.Text = "";
        }

        private void btn7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D7)
            {

                btn7.Focus();
                btn7.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                btn7.Focus();
                btn7.PerformClick();
            }
        }

        private void btn8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D8)
            {
                btn8.Focus();
                btn8.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                btn8.Focus();
                btn8.PerformClick();
            }
        }

        private void btn9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D9)
            {
                btn9.Focus();
                btn9.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad9)
            {
                btn9.Focus();
                btn9.PerformClick();
            }
        }

        private void btnDivide_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Divide)
            {
                btnDivide.Focus();
                btnDivide.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                btnDivide.Focus();
                btnDivide.PerformClick();
            }
        }

        private void btnCE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCE.PerformClick();
            }
           
        }

        private void btnC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnC.PerformClick();
            }

        }

        private void btnGange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Subtract)
            {
                btnGange.PerformClick();
            }
         
        }

        private void btn6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D6)
            {
                btn6.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                btn6.PerformClick();
            }
        }

        private void btn5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D5)
            {
                btn5.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                btn5.PerformClick();
            }
        }

        private void btn4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D4)
            {
                btn4.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                btn4.PerformClick();
            }
        }

        private void btn1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                btn1.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad1)
            {
                btn1.PerformClick();
            }
        }

        private void btn2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D2)
            {
                btn2.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                btn2.PerformClick();
            }
        }

        private void btn3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D3)
            {
                btn3.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                btn3.PerformClick();
            }
        }

        private void btnMinus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemMinus)
            {
                btnMinus.PerformClick();
            }

        }

        private void btnEqual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEqual.PerformClick();
            }

        }

        private void btnPluss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemplus)
            {
                btnPluss.PerformClick();
            }

        }

        private void btnDot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemcomma)
            {
                btnDot.PerformClick();
            }

        }

        private void btn0_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0)
            {
                btn0.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad0)
            {
                btn0.PerformClick();
            }
        }
    }
    }
    

