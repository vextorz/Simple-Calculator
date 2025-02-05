///////////////////////////////////////////////////////////////////
// Duc Vy Dang
// TINFO-200, Winter 2024
// This program handle event of the calculator
//
// Change History
// Date           Developer             Description
// 2024-01-16     Duc Vy Dang           Initial creation of program, app, and this file.
// 2024-01-18     Duc Vy Dang           Creating button handle of number buttons, display text of the calculator.
// 2024-01-23     Duc Vy Dang           Adding math operation handler, finishing math operation buttons.
// 2024-01-27     Duc Vy Dang           Replaced leading zero with number when press. Final check of this event handler program.


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
    // what is this event handler
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // this event handler will record all the number key buttons and display
        private void numBtn_Click(object sender, EventArgs e)
        {
            // casting the sender paramater passed into type button
            Button btn = (Button)sender;

            // get rid of leading zero when user put in number
            // then display the number that user typed in
            if (display.Text == "0")
            {
                display.Text = btn.Text;
            }
            else
            {
                display.Text = display.Text + btn.Text;
            }
          
        }
        // 3 instance vars will hold the state of the calc before
        // and during math operation
        // storage for the first operand of the math operation
        private double leftOperand = 0.0;

        // storage for the current selected math operation
        private string mathOperation = string.Empty;

        // signals that we have started into a math operation
        private bool beginMathOp = false;

        // Clear entry should zero out this display - leaving any variables
        // or memorized state of the calculator in place
        private void clearEntryBtn_Click(object sender, EventArgs e)
        {

            // just clear the display and leave the state vars alone
            display.Text = "0";
        }

        // clear ALL should zero out display
        // and also clear variables or memorized state of the calculator
        private void clearBtn_Click(object sender, EventArgs e)
        {
            // reset the state held in the instance variables
            beginMathOp = false;
            leftOperand = 0.0;
            mathOperation = string.Empty;

            display.Text = "0";
            
        }


        private void mathOpBtn_Click(object sender, EventArgs e)
        {
            // signal that a math operation has actually started
            beginMathOp = true;

            // load up the "global" class wide instance vars
            leftOperand = double.Parse(display.Text);
            
            // 
            //Button btn = (Button)sender;
            mathOperation = ((Button)sender).Text;

            // clear the display
            display.Clear();
        }

        // the equal sign handler is the one that does the math
        // operation of the calc
        private void equalBtn_Click(object sender, EventArgs e)
        {
            // decide what math operation is and do the math.
            switch (mathOperation)
            {
                case "+":
                    display.Text = (leftOperand + double.Parse(display.Text)).ToString();
                    break;
                case "-":
                    display.Text = (leftOperand - double.Parse(display.Text)).ToString();
                    break;
                case "x":
                    display.Text = (leftOperand * double.Parse(display.Text)).ToString();
                    break;
                case "/":
                    display.Text = (leftOperand / double.Parse(display.Text)).ToString();
                    break;
                default:
                    MessageBox.Show("ERROR: This code should be unreachable");
                    break;
            }
            

        }

        // handle the positive/negative button
        private void plusMinusBtn_Click(object sender, EventArgs e)
        {
            // Same basic operation as the "equal handler, but negation is unary and doesn't
            // need the left operand
            display.Text = (- double.Parse(display.Text)).ToString();
        }

        private void backSpaceBtn_Click(object sender, EventArgs e)
        {
            // if statement that checks to make sure that there are
            // at least 1 chars in the display.text

            // normal scenario
            if (display.Text.Length > 1) 
            { 
            display.Text = display.Text.Substring(0, display.Text.Length - 1);
            }
        }

        // example of a C# lambda expression
        private void decimalBtn_Click2(object sender, EventArgs e) =>
            display.Text = display.Text.Contains(".") ? display.Text : display.Text + ".";

        // this is the original method (traditional method definition)
        private void decimalBtn_Click(object sender, EventArgs e)
        {
            // this is an example of the C# ternary operator
             display.Text = display.Text.Contains(".") ? display.Text : display.Text + ".";

        }
    }
}
