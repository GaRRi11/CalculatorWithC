using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithC_
{
    public class Calculator
    {
        private double result;

        public double add(double num1, double num2) {
            return num1 + num2;
        }
        public double subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                MessageBox.Show("Division by zero is not allowed.");
            }
            return num1 / num2;
        }
        public double CalculatePercentage(double num)
        {
            return num / 100;
        }
        public double giveResult(double num1, double num2, String operators) {
            switch (operators)
            {
                case "+":
                    result = add(num1, num2);
                    break;
                case "-":
                    result = subtract(num1, num2);
                    break;
                case "*":
                    result = multiply(num1, num2);
                    break;
                case "/":
                    result = divide(num1, num2);
                    break;
            }
            return result;
        }


    }
}
