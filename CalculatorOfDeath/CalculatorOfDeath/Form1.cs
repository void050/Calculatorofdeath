using System;
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

        
        private void Transmitter(string name)
        {
            try
            {
                double firstArgument = Convert.ToDouble(firstArgumentField.Text);
                if(secondArgumentField.Text=="")
                     secondArgumentField.Text = "0";
                double secondArgument = Convert.ToDouble(secondArgumentField.Text);
                IBinaryCalculator calculator = BinaryOperationFactory.Create(name);
                result.Text = calculator.Calculate(firstArgument, secondArgument).ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Trans(string name)
        {
            try
            {
                double firstArgument = Convert.ToDouble(firstArgumentField.Text);
                IUnaryCalculator calculator = UnaryOperationFactory.Create(name);
                result.Text = calculator.Calculate(firstArgument).ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void AdderClick(object sender, EventArgs e)
        {
           Transmitter("Adder");
        }

        private void SubstractionClick(object sender, EventArgs e)
        {
            Transmitter("Substraction");
        }

        private void MultiplicationClick(object sender, EventArgs e)
        {
            Transmitter("Multiplication");
        }

        private void DivisionClick(object sender, EventArgs e)
        {
            Transmitter("Division");
        }

        private void FactorialClick(object sender, EventArgs e)
        {
            Trans("Factorial");
        }

        private void SquareClick(object sender, EventArgs e)
        {
            Trans("Square");
        }

        private void AbsoluteClick(object sender, EventArgs e)
        {
            Trans("Absolute");
        }

        private void ModClick(object sender, EventArgs e)
        {
            Transmitter("Mod");
        }

        private void PercentClick(object sender, EventArgs e)
        {
            Transmitter("Percent");
        }

        private void SquarePowerClick(object sender, EventArgs e)
        {
            Trans("SquarePower");
        }

        private void SinClick(object sender, EventArgs e)
        {
            Trans("Sin");
        }

        private void DegreeClick(object sender, EventArgs e)
        {
            Transmitter("Degree");
        }

        private void TenPowerClick(object sender, EventArgs e)
        {
            Trans("TenPower");
        }

        private void DeleteXClick(object sender, EventArgs e)
        {
            Trans("DeleteX");
        }

        private void CubeRootClick(object sender, EventArgs e)
        {
            Trans("CubeRoot");
        }

        private void CosClick(object sender, EventArgs e)
        {
            Trans("Cos");
        }

        private void ExpClick(object sender, EventArgs e)
        {
            Trans("Exp");
        }

        private void LogClick(object sender, EventArgs e)
        {
            Transmitter("Log");
        }

        private void SquareDegreesClick(object sender, EventArgs e)
        {
            Transmitter("SquareDegrees");
        }

        private void LogeClick(object sender, EventArgs e)
        {
            Trans("Loge");
        }

        private void PiNClick(object sender, EventArgs e)
        {
            Trans("PiN");
        }

        private void TanClick(object sender, EventArgs e)
        {
            Trans("Tan");
        }

        private void PiDivNClick(object sender, EventArgs e)
        {
            Trans("PiDivN");
        }

        private void SqrtABClick(object sender, EventArgs e)
        {
            Transmitter("SqrtAB");                              
        }

        private void SortOne(string name)
        {
            try
            {
                string[] stringArray = firstArgumentField.Text.Trim().Split(' ');
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            SortOne("BubbleSort");
        }

        private void CombSort_Click(object sender, EventArgs e)
        {
            SortOne("CombSort");
        }

        private void CocktailSort_Click(object sender, EventArgs e)
        {
            SortOne("CocktailSort");
        }
        
        private void NativeSort_Click(object sender, EventArgs e)
        {
            SortOne("NativeSort");
        }

        private void tgOperation_Click(object sender, EventArgs e)
        {
            Trans("ArcTan");
        }

        private void ArcSin_Click(object sender, EventArgs e)
        {
            Trans("ArcSin");
        }

        private void ArcCos_Click(object sender, EventArgs e)
        {
            Trans("ArcCos");
        }

        private void ArcCtg_Click(object sender, EventArgs e)
        {
            Trans ("ArcCtg");
        }

        private void GS_Click(object sender, EventArgs e)
        {
            SortOne ("GS");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SortOne("RandomSort");
        }

    }
}