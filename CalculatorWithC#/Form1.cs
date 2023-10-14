using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

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



        private string currentOperator = "";
        private Calculator calculator = new Calculator();



        private void DigitButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (int.TryParse(button.Text, out int digit))
                {
                    ResetColor();
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

                    ResetColor();
                    button.BackColor = getColorFromProperties();
                    currentOperator = button.Text;
                    calculator.AddNumber(input);
                    calculator.AddOperator(currentOperator);
                    textBox1.Clear();
                }
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double input))
            {
                calculator.AddNumber(input);
                double result = calculator.giveResult();
                textBox1.Text = result.ToString();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResetColor();
            calculator.clear();
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
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void ResetColor()
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.White;
                }
            }
        }

        private Color getColorFromProperties()
        {

            Color color;

            string appConfigFilePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "appconfig.xml");

            XmlDocument doc = new XmlDocument();
            doc.Load(appConfigFilePath);

            string xpath = "/configuration/appSettings/add[@key='ButtonColor']";

            XmlNode node = doc.SelectSingleNode(xpath);

            string buttonColor = node.Attributes["value"].Value;

            if (string.IsNullOrEmpty(buttonColor))
            {
                return Color.Black;
            }
            else {
                if (Enum.TryParse(buttonColor, true, out KnownColor knownColor))
                {
                    color = Color.FromKnownColor(knownColor);
                }
                else
                {
                    color = Color.Black;
                }
            }

            return color;

        }
    }
}