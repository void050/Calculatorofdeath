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


        private void transmitter(string name)
        {
            double FirstArgument = Convert.ToDouble(firstArgumentField.Text);
            double SecondArgument = Convert.ToDouble(secondArgumentField.Text);
            IBinaryCalculator calculator = BinaryOperationFactory.Create(name);
            result.Text = calculator.Calculate(FirstArgument, SecondArgument);
        }


        private void button1_Click(object sender, EventArgs e)
        {
           transmitter("Adder");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transmitter("Substraction");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            transmitter("Multiplication");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            transmitter("Division");
           /* if (SecondArgument != 0.0f) //This is feature of calculatorOfDeath,Our calculator can divide by zero
                  result.Text = division.Calculate(FirstArgument, SecondArgument);
            else
            {
                result.Text = "Мама ама криминал";
            }*/
        }
    }
}

