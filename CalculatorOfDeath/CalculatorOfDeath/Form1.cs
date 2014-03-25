using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorOfDeath.BinaryOperations;

namespace CalculatorOfDeath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double FirstArgument = Convert.ToDouble(firstArgumentField.Text);
            double SecondArgument = Convert.ToDouble(secondArgumentField.Text);
            Adder adder = new Adder();
            result.Text = adder.Calculate(FirstArgument, SecondArgument);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double FirstArgument = Convert.ToDouble(firstArgumentField.Text);
            double SecondArgument = Convert.ToDouble(secondArgumentField.Text);
            Subtraction subtraction = new Subtraction();
            result.Text = subtraction.Calculate(FirstArgument, SecondArgument);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double FirstArgument = Convert.ToDouble(firstArgumentField.Text);
            double SecondArgument = Convert.ToDouble(secondArgumentField.Text);
            Multiplication multiplication = new Multiplication();
            result.Text = multiplication.Calculate(FirstArgument, SecondArgument);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double FirstArgument = Convert.ToDouble(firstArgumentField.Text);
            double SecondArgument = Convert.ToDouble(secondArgumentField.Text);
            Division division = new Division();
            if (SecondArgument != 0.0f) //This is feature of calculatorOfDeath,Our calculator can divide by zero
                  result.Text = division.Calculate(FirstArgument, SecondArgument);
            else
            {
                result.Text = "Мама ама криминал";
            }
        }
    }
}

