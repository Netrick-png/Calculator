using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string operation = "";
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonNumber_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || isOperationPerformed)
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox_Result.Text += button.Text;
        }

        private void buttonOperator_Click(object sender, EventArgs e)  //нажатие на кнопки операций +, -, *, /, ^, √
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(textBox_Result.Text);
            isOperationPerformed = true;
            label_Expression.Text = result + " " + operation;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(textBox_Result.Text);
            switch (operation)
            {
                case "+":
                    textBox_Result.Text = (result + secondNumber).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (result - secondNumber).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (result * secondNumber).ToString();
                    break;
                case "/":
                    if (secondNumber != 0)
                        textBox_Result.Text = (result / secondNumber).ToString();
                    else
                        textBox_Result.Text = "Error";
                    break;
                case "^":
                    textBox_Result.Text = Math.Pow(result, secondNumber).ToString();
                    break;
                case "√":
                    if (result >= 0)
                        textBox_Result.Text = Math.Sqrt(result).ToString();
                    else
                        textBox_Result.Text = "Error";
                    break;
            }
            label_Expression.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            result = 0;
            operation = "";
            label_Expression.Text = "";
        }

        private void buttonSqrt_Click(object sender, EventArgs e) // нажатие на кнопку квадратный корень
        {
            double number = double.Parse(textBox_Result.Text);
            if (number >= 0)
            {
                textBox_Result.Text = Math.Sqrt(number).ToString();
                label_Expression.Text = "√" + number;
            }
            else
            {
                textBox_Result.Text = "Error";
            }
        }

        private void buttonPower_Click(object sender, EventArgs e)  //  нажатие на кнопку возведение в степень
        {
            operation = "^";
            result = double.Parse(textBox_Result.Text);
            isOperationPerformed = true;
            label_Expression.Text = result + " ^";
        }
    }
}