namespace CalculatorOfDeath
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstArgumentField = new System.Windows.Forms.TextBox();
            this.secondArgumentField = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.Adder = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Absolute = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Button();
            this.SquarePower = new System.Windows.Forms.Button();
            this.TenPower = new System.Windows.Forms.Button();
            this.Degree = new System.Windows.Forms.Button();
            this.DeleteX = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.CubeRoot = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Exp = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.SquareDegrees = new System.Windows.Forms.Button();
            this.Loge = new System.Windows.Forms.Button();
            this.PiN = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.PiDivN = new System.Windows.Forms.Button();
            this.SqrtAB = new System.Windows.Forms.Button();
            this.BubbleSort = new System.Windows.Forms.Button();
            this.CombSort = new System.Windows.Forms.Button();
            this.CocktailSort = new System.Windows.Forms.Button();
            this.NativeSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstArgumentField
            // 
            this.firstArgumentField.Location = new System.Drawing.Point(12, 12);
            this.firstArgumentField.Name = "firstArgumentField";
            this.firstArgumentField.Size = new System.Drawing.Size(97, 20);
            this.firstArgumentField.TabIndex = 0;
            // 
            // secondArgumentField
            // 
            this.secondArgumentField.Location = new System.Drawing.Point(146, 12);
            this.secondArgumentField.Name = "secondArgumentField";
            this.secondArgumentField.Size = new System.Drawing.Size(97, 20);
            this.secondArgumentField.TabIndex = 1;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(313, 12);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(178, 20);
            this.result.TabIndex = 2;
            // 
            // Adder
            // 
            this.Adder.BackColor = System.Drawing.Color.Tan;
            this.Adder.Location = new System.Drawing.Point(18, 61);
            this.Adder.Name = "Adder";
            this.Adder.Size = new System.Drawing.Size(50, 50);
            this.Adder.TabIndex = 3;
            this.Adder.Text = "+";
            this.Adder.UseVisualStyleBackColor = false;
            this.Adder.Click += new System.EventHandler(this.AdderClick);
            // 
            // Subtraction
            // 
            this.Subtraction.BackColor = System.Drawing.Color.Tan;
            this.Subtraction.Location = new System.Drawing.Point(18, 117);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(50, 50);
            this.Subtraction.TabIndex = 4;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = false;
            this.Subtraction.Click += new System.EventHandler(this.SubtractionClick);
            // 
            // Multiplication
            // 
            this.Multiplication.BackColor = System.Drawing.Color.Tan;
            this.Multiplication.Location = new System.Drawing.Point(19, 174);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(49, 50);
            this.Multiplication.TabIndex = 5;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = false;
            this.Multiplication.Click += new System.EventHandler(this.MultiplicationClick);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.Color.Tan;
            this.Division.Location = new System.Drawing.Point(19, 229);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(49, 49);
            this.Division.TabIndex = 6;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.DivisionClick);
            // 
            // Factorial
            // 
            this.Factorial.BackColor = System.Drawing.Color.Tan;
            this.Factorial.Location = new System.Drawing.Point(180, 174);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(100, 50);
            this.Factorial.TabIndex = 7;
            this.Factorial.Text = "Факториал";
            this.Factorial.UseVisualStyleBackColor = false;
            this.Factorial.Click += new System.EventHandler(this.FactorialClick);
            // 
            // Square
            // 
            this.Square.BackColor = System.Drawing.Color.Tan;
            this.Square.Location = new System.Drawing.Point(74, 118);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(100, 50);
            this.Square.TabIndex = 8;
            this.Square.Text = "Корень";
            this.Square.UseVisualStyleBackColor = false;
            this.Square.Click += new System.EventHandler(this.SquareClick);
            // 
            // Absolute
            // 
            this.Absolute.BackColor = System.Drawing.Color.Tan;
            this.Absolute.Location = new System.Drawing.Point(74, 173);
            this.Absolute.Name = "Absolute";
            this.Absolute.Size = new System.Drawing.Size(100, 50);
            this.Absolute.TabIndex = 9;
            this.Absolute.Text = "Модуль";
            this.Absolute.UseVisualStyleBackColor = false;
            this.Absolute.Click += new System.EventHandler(this.AbsoluteClick);
            // 
            // Mod
            // 
            this.Mod.BackColor = System.Drawing.Color.Tan;
            this.Mod.Location = new System.Drawing.Point(180, 118);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(100, 50);
            this.Mod.TabIndex = 13;
            this.Mod.Text = "С остатком";
            this.Mod.UseVisualStyleBackColor = false;
            this.Mod.Click += new System.EventHandler(this.ModClick);
            // 
            // Percent
            // 
            this.Percent.BackColor = System.Drawing.Color.Tan;
            this.Percent.Location = new System.Drawing.Point(74, 61);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(100, 50);
            this.Percent.TabIndex = 14;
            this.Percent.Text = "Процент";
            this.Percent.UseVisualStyleBackColor = false;
            this.Percent.Click += new System.EventHandler(this.PercentClick);
            // 
            // SquarePower
            // 
            this.SquarePower.BackColor = System.Drawing.Color.Tan;
            this.SquarePower.Location = new System.Drawing.Point(180, 230);
            this.SquarePower.Name = "SquarePower";
            this.SquarePower.Size = new System.Drawing.Size(100, 49);
            this.SquarePower.TabIndex = 15;
            this.SquarePower.Text = "x^2";
            this.SquarePower.UseVisualStyleBackColor = false;
            this.SquarePower.Click += new System.EventHandler(this.SquarePowerClick);
            // 
            // TenPower
            // 
            this.TenPower.BackColor = System.Drawing.Color.Tan;
            this.TenPower.Location = new System.Drawing.Point(286, 61);
            this.TenPower.Name = "TenPower";
            this.TenPower.Size = new System.Drawing.Size(100, 50);
            this.TenPower.TabIndex = 16;
            this.TenPower.Text = "10^x";
            this.TenPower.UseVisualStyleBackColor = false;
            this.TenPower.Click += new System.EventHandler(this.TenPowerClick);
            // 
            // Degree
            // 
            this.Degree.BackColor = System.Drawing.Color.Tan;
            this.Degree.Location = new System.Drawing.Point(286, 118);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(100, 50);
            this.Degree.TabIndex = 17;
            this.Degree.Text = "x^y";
            this.Degree.UseVisualStyleBackColor = false;
            this.Degree.Click += new System.EventHandler(this.DegreeClick);
            // 
            // DeleteX
            // 
            this.DeleteX.BackColor = System.Drawing.Color.Tan;
            this.DeleteX.Location = new System.Drawing.Point(286, 174);
            this.DeleteX.Name = "DeleteX";
            this.DeleteX.Size = new System.Drawing.Size(100, 50);
            this.DeleteX.TabIndex = 18;
            this.DeleteX.Text = "1/x";
            this.DeleteX.UseVisualStyleBackColor = false;
            this.DeleteX.Click += new System.EventHandler(this.DeleteXClick);
            // 
            // Sin
            // 
            this.Sin.BackColor = System.Drawing.Color.Tan;
            this.Sin.Location = new System.Drawing.Point(392, 61);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(100, 50);
            this.Sin.TabIndex = 19;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = false;
            this.Sin.Click += new System.EventHandler(this.SinClick);
            // 
            // CubeRoot
            // 
            this.CubeRoot.BackColor = System.Drawing.Color.Tan;
            this.CubeRoot.Location = new System.Drawing.Point(286, 229);
            this.CubeRoot.Name = "CubeRoot";
            this.CubeRoot.Size = new System.Drawing.Size(100, 49);
            this.CubeRoot.TabIndex = 20;
            this.CubeRoot.Text = "sqrt(3)";
            this.CubeRoot.UseVisualStyleBackColor = false;
            this.CubeRoot.Click += new System.EventHandler(this.CubeRootClick);
            // 
            // Cos
            // 
            this.Cos.BackColor = System.Drawing.Color.Tan;
            this.Cos.Location = new System.Drawing.Point(392, 117);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(100, 50);
            this.Cos.TabIndex = 21;
            this.Cos.Text = "cos";
            this.Cos.UseVisualStyleBackColor = false;
            this.Cos.Click += new System.EventHandler(this.CosClick);
            // 
            // Exp
            // 
            this.Exp.BackColor = System.Drawing.Color.Tan;
            this.Exp.Location = new System.Drawing.Point(392, 173);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(100, 49);
            this.Exp.TabIndex = 22;
            this.Exp.Text = "exp";
            this.Exp.UseVisualStyleBackColor = false;
            this.Exp.Click += new System.EventHandler(this.ExpClick);
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.Tan;
            this.Log.Location = new System.Drawing.Point(391, 229);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(100, 49);
            this.Log.TabIndex = 23;
            this.Log.Text = "log(x, y)";
            this.Log.UseVisualStyleBackColor = false;
            this.Log.Click += new System.EventHandler(this.LogClick);
            // 
            // SquareDegrees
            // 
            this.SquareDegrees.BackColor = System.Drawing.Color.Tan;
            this.SquareDegrees.Location = new System.Drawing.Point(498, 61);
            this.SquareDegrees.Name = "SquareDegrees";
            this.SquareDegrees.Size = new System.Drawing.Size(100, 50);
            this.SquareDegrees.TabIndex = 24;
            this.SquareDegrees.Text = "sqrt(x, y)";
            this.SquareDegrees.UseVisualStyleBackColor = false;
            this.SquareDegrees.Click += new System.EventHandler(this.SquareDegreesClick);
            // 
            // Loge
            // 
            this.Loge.BackColor = System.Drawing.Color.Tan;
            this.Loge.Location = new System.Drawing.Point(498, 174);
            this.Loge.Name = "Loge";
            this.Loge.Size = new System.Drawing.Size(98, 48);
            this.Loge.TabIndex = 26;
            this.Loge.Text = "Log";
            this.Loge.UseVisualStyleBackColor = false;
            this.Loge.Click += new System.EventHandler(this.LogeClick);
            // 
            // PiN
            // 
            this.PiN.BackColor = System.Drawing.Color.Tan;
            this.PiN.Location = new System.Drawing.Point(498, 230);
            this.PiN.Name = "PiN";
            this.PiN.Size = new System.Drawing.Size(98, 48);
            this.PiN.TabIndex = 27;
            this.PiN.Text = "Pi^n";
            this.PiN.UseVisualStyleBackColor = false;
            this.PiN.Click += new System.EventHandler(this.PiNClick);
            // 
            // Tan
            // 
            this.Tan.BackColor = System.Drawing.Color.Tan;
            this.Tan.Location = new System.Drawing.Point(76, 229);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(98, 48);
            this.Tan.TabIndex = 28;
            this.Tan.Text = "Tg";
            this.Tan.UseVisualStyleBackColor = false;
            this.Tan.Click += new System.EventHandler(this.TanClick);
            // 
            // PiDivN
            // 
            this.PiDivN.BackColor = System.Drawing.Color.Tan;
            this.PiDivN.Location = new System.Drawing.Point(180, 64);
            this.PiDivN.Name = "PiDivN";
            this.PiDivN.Size = new System.Drawing.Size(98, 48);
            this.PiDivN.TabIndex = 29;
            this.PiDivN.Text = "Pi/n";
            this.PiDivN.UseVisualStyleBackColor = false;
            this.PiDivN.Click += new System.EventHandler(this.PiDivNClick);
            // 
            // SqrtAB
            // 
            this.SqrtAB.BackColor = System.Drawing.Color.Tan;
            this.SqrtAB.Location = new System.Drawing.Point(500, 117);
            this.SqrtAB.Name = "SqrtAB";
            this.SqrtAB.Size = new System.Drawing.Size(98, 48);
            this.SqrtAB.TabIndex = 30;
            this.SqrtAB.Text = "Sqrt(a+b)";
            this.SqrtAB.UseVisualStyleBackColor = false;
            this.SqrtAB.Click += new System.EventHandler(this.SqrtABClick);
            // 
            // BubbleSort
            // 
            this.BubbleSort.BackColor = System.Drawing.Color.Gold;
            this.BubbleSort.Location = new System.Drawing.Point(61, 283);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(120, 35);
            this.BubbleSort.TabIndex = 31;
            this.BubbleSort.Text = "Сортировка пузырьком";
            this.BubbleSort.UseVisualStyleBackColor = false;
            this.BubbleSort.Click += new System.EventHandler(this.BubbleSort_Click);
            // 
            // CombSort
            // 
            this.CombSort.BackColor = System.Drawing.Color.Gold;
            this.CombSort.Location = new System.Drawing.Point(187, 283);
            this.CombSort.Name = "CombSort";
            this.CombSort.Size = new System.Drawing.Size(120, 35);
            this.CombSort.TabIndex = 32;
            this.CombSort.Text = "Расческой";
            this.CombSort.UseVisualStyleBackColor = false;
            this.CombSort.Click += new System.EventHandler(this.CombSort_Click);
            // 
            // CocktailSort
            // 
            this.CocktailSort.BackColor = System.Drawing.Color.Gold;
            this.CocktailSort.Location = new System.Drawing.Point(439, 283);
            this.CocktailSort.Name = "CocktailSort";
            this.CocktailSort.Size = new System.Drawing.Size(120, 34);
            this.CocktailSort.TabIndex = 33;
            this.CocktailSort.Text = "Перемешиванием (коктейльная)";
            this.CocktailSort.UseVisualStyleBackColor = false;
            this.CocktailSort.Click += new System.EventHandler(this.CocktailSort_Click);
            // 
            // NativeSort
            // 
            this.NativeSort.BackColor = System.Drawing.Color.Gold;
            this.NativeSort.Location = new System.Drawing.Point(313, 283);
            this.NativeSort.Name = "NativeSort";
            this.NativeSort.Size = new System.Drawing.Size(120, 35);
            this.NativeSort.TabIndex = 34;
            this.NativeSort.Text = "Родная";
            this.NativeSort.UseVisualStyleBackColor = false;
            this.NativeSort.Click += new System.EventHandler(this.NativeSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(623, 340);
            this.Controls.Add(this.NativeSort);
            this.Controls.Add(this.CocktailSort);
            this.Controls.Add(this.CombSort);
            this.Controls.Add(this.BubbleSort);
            this.Controls.Add(this.SqrtAB);
            this.Controls.Add(this.PiDivN);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.PiN);
            this.Controls.Add(this.Loge);
            this.Controls.Add(this.SquareDegrees);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.CubeRoot);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.DeleteX);
            this.Controls.Add(this.Degree);
            this.Controls.Add(this.TenPower);
            this.Controls.Add(this.SquarePower);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.Absolute);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Adder);
            this.Controls.Add(this.result);
            this.Controls.Add(this.secondArgumentField);
            this.Controls.Add(this.firstArgumentField);
            this.Name = "Form1";
            this.Text = "CalculatorOfDeath";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstArgumentField;
        private System.Windows.Forms.TextBox secondArgumentField;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button Adder;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Factorial;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Absolute;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.Button Percent;
        private System.Windows.Forms.Button SquarePower;
        private System.Windows.Forms.Button TenPower;
        private System.Windows.Forms.Button Degree;
        private System.Windows.Forms.Button DeleteX;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button CubeRoot;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Exp;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button SquareDegrees;
        private System.Windows.Forms.Button Loge;
        private System.Windows.Forms.Button PiN;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button PiDivN;
        private System.Windows.Forms.Button SqrtAB;
        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.Button CombSort;
        private System.Windows.Forms.Button CocktailSort;
        private System.Windows.Forms.Button NativeSort;
     }
}

