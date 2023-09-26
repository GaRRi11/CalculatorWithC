using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithC_
{
    public class Calculator
    {
        private double result;
        private List<double> numbers = new List<double>();
        private List<string> allOperators = new List<string>();


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

        public void AddNumber(double num)
        {
            numbers.Add(num);
        }

        public void clear()
        {
            numbers.Clear();
            allOperators.Clear();
            result = 0;
        }

        public void AddOperator(string op)
        {
            allOperators.Add(op);
        }
        public double giveResult() {
            List<string> multiplicationAndDivision = new List<string> { "*", "/" };
            List<string> plusAndMinus = new List<string> { "+", "-" };

            foreach (string op in multiplicationAndDivision)
            {
                for (int i = 0; i < allOperators.Count; i++)
                {
                    if (allOperators[i] == op)
                    {
                        double num1 = numbers[i];
                        double num2 = numbers[i + 1];

                        double result = 0;
                        switch (op)
                        {
                            case "*":
                                result = multiply(num1, num2);
                                break;
                            case "/":
                                result = divide(num1, num2);
                                break;
                        }

                        numbers[i] = result;
                        numbers.RemoveAt(i + 1);
                        allOperators.RemoveAt(i);

                        i--;
                    }
                }
            }

            foreach (string op in plusAndMinus)
            {
                for (int i = 0; i < allOperators.Count; i++)
                {
                    if (allOperators[i] == op)
                    {
                        double num1 = numbers[i];
                        double num2 = numbers[i + 1];

                        double result = 0;
                        switch (op)
                        {
                            case "+":
                                result = add(num1, num2);
                                break;
                            case "-":
                                result = subtract(num1, num2);
                                break;
                        }

                        numbers[i] = result;
                        numbers.RemoveAt(i + 1);
                        allOperators.RemoveAt(i);

                        i--;
                    }
                }
            }

            double finalResult = numbers[0];

            clear();

            return finalResult;
        

        }


}
}
