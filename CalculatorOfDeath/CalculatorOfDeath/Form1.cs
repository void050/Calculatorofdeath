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
using CalculatorOfDeath.UnaryOperations;

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
            if(secondArgumentField.Text=="")
                 secondArgumentField.Text = "0";
            double SecondArgument = Convert.ToDouble(secondArgumentField.Text);
            IBinaryCalculator calculator = BinaryOperationFactory.Create(name);
            result.Text = calculator.Calculate(FirstArgument, SecondArgument);
        }

        private void trans(string name)
        {
            double FirstArgument = Convert.ToDouble(firstArgumentField.Text);
            IUnaryCalculator calculator = UnaryOperationFactory.Create(name);
            result.Text = calculator.Calculate(FirstArgument);
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
   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            trans("Factorial");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            trans("Square");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            transmitter("Absolute");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            transmitter("Binary");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            transmitter("Octal");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            transmitter("Mod");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            transmitter("Percent");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            trans("SquarePower");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            trans("Sin");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            transmitter("Degree");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            trans("TenPower");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            trans("DeleteX");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            trans("CubeRoot");
        }
    }
}

