using System;
using System.Text.RegularExpressions;

namespace TestExpleoNy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write a mathematical expression");

            //Calculator calculator = new Calculator();
            //calculator.answ = Console.ReadLine();

            Calculator.answ = Console.ReadLine();

            Console.WriteLine(Calculator.CalculatePrint(Calculator.answ));
            //if (Calculator.Operators(Calculator.StringOperator) == "+")
            //{
            //    Console.WriteLine(Calculator.Addition(Calculator.InputNumber1(Calculator.Input1), Calculator.InputNumber2(Calculator.Input2)));
                
            //}

            
            

        }
    }
    public static class Calculator
    {

        public static double CalculatePrint(string output)
        {
            if (Operators(StringOperator) == "+")
            {
                
                return Addition(InputNumber1(Input1), InputNumber2(Input2));
            }

            else if (Operators(StringOperator) == "-")
            {

                return Subtraction(InputNumber1(Input1), InputNumber2(Input2));
            }

            else if (Operators(StringOperator) == "*")
            {

                return Multiplication(InputNumber1(Input1), InputNumber2(Input2));
            }
            else if (Operators(StringOperator) == "/")
            {

                return Division(InputNumber1(Input1), InputNumber2(Input2));
            }

            return 0;
        }

        public static string answ;

        public static double Input1 { get; set; }
       
        public static double InputNumber1(double num1)
        {
            Match matchNumbers = Regex.Match(answ, @"([0-9]+)");

            if (matchNumbers.Success)
            {
                double item1 = double.Parse(matchNumbers.Value);
                Input1 = item1;
            }
            return Input1;

        }

        public static double Input2 { get; set; }

        public static double InputNumber2(double num2)
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

       

        public static string StringOperator { get; set; }
        public static string Operators(string operat)
        {
            Match matchOp = Regex.Match(answ, @"([*+/-])");

            if (matchOp.Success)
            {
                string operate = matchOp.Value;
                StringOperator = operate;
            }
            return StringOperator;
        }


        public static double Addition(double item1, double item2)
        {

            return item1 + item2;
        }

        public static double Subtraction(double item1, double item2)
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

        public static double Multiplication(double item1, double item2)
        {
            return item1 * item2;
        }

        public static double Division(double item1, double item2)
        {
            return item1 / item2;
        }


    }
}
