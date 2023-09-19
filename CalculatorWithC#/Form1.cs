using System.Diagnostics;
using System.Drawing;

namespace CalculatorWithC_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Resize_1(object sender, EventArgs e)
        {
        }



        private double currentInput = 0;
        private string currentOperator = "";
        private Calculator calculator = new Calculator();

        private Button FindButtonByText(string buttonText)
        {
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Text == buttonText)
                {
                    return button;
                }
            }

            return null;
        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (int.TryParse(button.Text, out int digit))
                {
                    Button foundButton = FindButtonByText(currentOperator);
                    if (foundButton != null)
                    {
                        foundButton.BackColor = Color.White;
                    }
                    textBox1.Text += button.Text;
                }
            }

        }
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (double.TryParse(textBox1.Text, out double input))
                {
                    Color buttonCollor = Properties.Settings.Default.ButtonColor;
                    button.BackColor = buttonCollor;
                    currentInput = input;
                    currentOperator = button.Text;
                    textBox1.Clear();
                }
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double input))
            {

                currentInput = calculator.giveResult(currentInput, input, currentOperator);
                textBox1.Text = currentInput.ToString();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void MinusPlusButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("-"))
            {
                textBox1.Text = textBox1.Text.Trim('-');
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        private void PercentageButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double input))
            {
                textBox1.Text = calculator.CalculatePercentage(input).ToString();
            }
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

       
    }
}