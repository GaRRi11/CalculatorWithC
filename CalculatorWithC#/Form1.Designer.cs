namespace CalculatorWithC_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clear = new Button();
            percent = new Button();
            seven = new Button();
            eight = new Button();
            nine = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            division = new Button();
            multiplication = new Button();
            minus = new Button();
            plus = new Button();
            equals = new Button();
            one = new Button();
            two = new Button();
            three = new Button();
            zero = new Button();
            dot = new Button();
            MinusPlus = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // clear
            // 
            clear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            clear.Location = new Point(0, 110);
            clear.Name = "clear";
            clear.Size = new Size(106, 87);
            clear.TabIndex = 0;
            clear.Text = "AC";
            clear.UseVisualStyleBackColor = true;
            clear.Click += ClearButton_Click;
            // 
            // percent
            // 
            percent.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            percent.Location = new Point(224, 108);
            percent.Name = "percent";
            percent.Size = new Size(106, 91);
            percent.TabIndex = 2;
            percent.Text = "%";
            percent.UseVisualStyleBackColor = true;
            percent.Click += PercentageButton_Click;
            // 
            // seven
            // 
            seven.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            seven.Location = new Point(2, 205);
            seven.Name = "seven";
            seven.Size = new Size(106, 89);
            seven.TabIndex = 4;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += DigitButton_Click;
            // 
            // eight
            // 
            eight.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            eight.Location = new Point(112, 203);
            eight.Name = "eight";
            eight.Size = new Size(106, 89);
            eight.TabIndex = 5;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += DigitButton_Click;
            // 
            // nine
            // 
            nine.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nine.Location = new Point(224, 205);
            nine.Name = "nine";
            nine.Size = new Size(106, 89);
            nine.TabIndex = 6;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += DigitButton_Click;
            // 
            // four
            // 
            four.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            four.Location = new Point(0, 300);
            four.Name = "four";
            four.Size = new Size(106, 89);
            four.TabIndex = 7;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += DigitButton_Click;
            // 
            // five
            // 
            five.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            five.Location = new Point(114, 300);
            five.Name = "five";
            five.Size = new Size(106, 89);
            five.TabIndex = 8;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += DigitButton_Click;
            // 
            // six
            // 
            six.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            six.Location = new Point(226, 300);
            six.Name = "six";
            six.Size = new Size(106, 89);
            six.TabIndex = 9;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += DigitButton_Click;
            // 
            // division
            // 
            division.FlatStyle = FlatStyle.Flat;
            division.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            division.Location = new Point(341, 110);
            division.Name = "division";
            division.Size = new Size(118, 89);
            division.TabIndex = 10;
            division.Text = "/";
            division.UseVisualStyleBackColor = true;
            division.Click += OperatorButton_Click;
            // 
            // multiplication
            // 
            multiplication.FlatStyle = FlatStyle.Flat;
            multiplication.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            multiplication.Location = new Point(341, 205);
            multiplication.Name = "multiplication";
            multiplication.Size = new Size(118, 89);
            multiplication.TabIndex = 11;
            multiplication.Text = "*";
            multiplication.UseVisualStyleBackColor = true;
            multiplication.Click += OperatorButton_Click;
            // 
            // minus
            // 
            minus.FlatStyle = FlatStyle.Flat;
            minus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            minus.Location = new Point(340, 300);
            minus.Name = "minus";
            minus.Size = new Size(119, 89);
            minus.TabIndex = 12;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += OperatorButton_Click;
            // 
            // plus
            // 
            plus.FlatStyle = FlatStyle.Flat;
            plus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            plus.Location = new Point(341, 395);
            plus.Name = "plus";
            plus.Size = new Size(118, 89);
            plus.TabIndex = 13;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += OperatorButton_Click;
            // 
            // equals
            // 
            equals.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            equals.Location = new Point(336, 490);
            equals.Name = "equals";
            equals.Size = new Size(123, 89);
            equals.TabIndex = 14;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = true;
            equals.Click += EqualsButton_Click;
            // 
            // one
            // 
            one.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            one.Location = new Point(2, 395);
            one.Name = "one";
            one.Size = new Size(106, 89);
            one.TabIndex = 15;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += DigitButton_Click;
            // 
            // two
            // 
            two.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            two.Location = new Point(112, 395);
            two.Name = "two";
            two.Size = new Size(106, 89);
            two.TabIndex = 16;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += DigitButton_Click;
            // 
            // three
            // 
            three.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            three.Location = new Point(224, 395);
            three.Name = "three";
            three.Size = new Size(106, 89);
            three.TabIndex = 17;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += DigitButton_Click;
            // 
            // zero
            // 
            zero.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            zero.Location = new Point(0, 490);
            zero.Name = "zero";
            zero.Size = new Size(218, 89);
            zero.TabIndex = 18;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += DigitButton_Click;
            // 
            // dot
            // 
            dot.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dot.Location = new Point(224, 490);
            dot.Name = "dot";
            dot.Size = new Size(106, 89);
            dot.TabIndex = 19;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += DotButton_Click;
            // 
            // MinusPlus
            // 
            MinusPlus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MinusPlus.Location = new Point(112, 110);
            MinusPlus.Name = "MinusPlus";
            MinusPlus.Size = new Size(106, 89);
            MinusPlus.TabIndex = 20;
            MinusPlus.Text = "+/-";
            MinusPlus.UseVisualStyleBackColor = true;
            MinusPlus.Click += MinusPlusButton_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 1);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(459, 101);
            textBox1.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(459, 574);
            Controls.Add(plus);
            Controls.Add(equals);
            Controls.Add(textBox1);
            Controls.Add(dot);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(clear);
            Controls.Add(zero);
            Controls.Add(minus);
            Controls.Add(one);
            Controls.Add(MinusPlus);
            Controls.Add(percent);
            Controls.Add(division);
            Controls.Add(seven);
            Controls.Add(four);
            Controls.Add(eight);
            Controls.Add(nine);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(multiplication);
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Form1";
            Load += Form1_Load;
            Resize += Form1_Resize_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clear;
        private Button percent;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button four;
        private Button five;
        private Button six;
        private Button division;
        private Button multiplication;
        private Button minus;
        private Button plus;
        private Button equals;
        private Button one;
        private Button two;
        private Button three;
        private Button zero;
        private Button dot;
        private Button MinusPlus;
        private TextBox textBox1;
    }
}