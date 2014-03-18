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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 50);
            this.button3.TabIndex = 5;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 49);
            this.button4.TabIndex = 6;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 396);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

