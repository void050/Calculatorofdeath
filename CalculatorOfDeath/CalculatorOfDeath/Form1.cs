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
using CalculatorOfDeath.Sort;
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
            result.Text = calculator.Calculate(FirstArgument, SecondArgument).ToString();
        }

        private void trans(string name)
        {
            double FirstArgument = Convert.ToDouble(firstArgumentField.Text);
            IUnaryCalculator calculator = UnaryOperationFactory.Create(name);
            result.Text = calculator.Calculate(FirstArgument).ToString();
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

        private void button18_Click(object sender, EventArgs e)
        {
            trans("Cos");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            trans("Exp");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            transmitter("Log");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            transmitter("SquareDegrees");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            trans("Loge");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            trans("PiN");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            trans("Tan");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            trans("PiDivN");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            transmitter("SqrtAB");                              
        }

        private void SortOne(string name)
        {
            string[] stringArray = firstArgumentField.Text.Split(' ');
            int[] array = new int[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                array[i] = Convert.ToInt32(stringArray[i]);
            }
            ISort sorter = SortFactory.CreateOperation(name);
            int[] soresult = sorter.Sort(array);
            string stringSoresult = string.Empty;
            foreach (int element in soresult)
            {
                stringSoresult += element + " ";
            }
            result.Text = stringSoresult;
        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            SortOne("BubbleSort");
        }

        private void CombSort_Click(object sender, EventArgs e)
        {
            SortOne("CombSort");
        }

    }
}