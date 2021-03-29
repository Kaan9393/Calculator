using System;
using System.Text.RegularExpressions;

namespace TestExpleoNy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write a mathematical expression");

            Calculator calculator = new Calculator();
            calculator.answ = Console.ReadLine();

            if (calculator.Operators(calculator.StringOperator) == "+")
            {
                calculator.Addition(calculator.Input1, calculator.Input2);
            }


        }
    }
    public class Calculator
    {
        public string answ;

        public string OpPropp { get; set; }

        public double Input1 { get; set; }
        public double Input2 { get; set; }

        public double InputNumber1(double num1)
        {
            Match matchNumbers = Regex.Match(answ, @"([0-9]+)");

            if (matchNumbers.Success)
            {
                double item1 = double.Parse(matchNumbers.Value);
                Input1 = item1;
            }
            return Input1;

        }

        public double InputNumber2(double num2)
        {

            Match matchNumbers = Regex.Match(answ, @"([0-9]+)");

            matchNumbers = matchNumbers.NextMatch();
            if (matchNumbers.Success)
            {
                double item2 = double.Parse(matchNumbers.Value);
                Input2 = item2;
            }
            return Input2;

        }

       

        public string StringOperator { get; set; }
        public string Operators(string operat)
        {
            Match matchOp = Regex.Match(answ, @"([*+/-])");

            if (matchOp.Success)
            {
                string operate = matchOp.Value;
                StringOperator = operate;
            }
            return StringOperator;
        }


        public double Addition(double item1, double item2)
        {

            return item1 + item2;
        }

        public double Subtraction(double item1, double item2)
        {
            if (item1 > item2)
            {
                return item1 - item2;
            }
            else
            {
                return item2 + item1;
            }
        }

        public double Multiplication(double item1, double item2)
        {
            return item1 * item2;
        }

        public double Division(double item1, double item2)
        {
            return item1 / item2;
        }


    }
}
