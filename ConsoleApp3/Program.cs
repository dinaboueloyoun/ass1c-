using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp3
{
    class MyClass
    {
        public int Value;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();
            //int number = Convert.ToInt32(input);
            //Console.WriteLine(number);
            #endregion
            #region q2
            //string text = "123abc";
            //int number = Convert.ToInt32(text);
            //Console.WriteLine( number);
            //The conversion fails because the string has non - numeric characters, which makes its format invalid for an integer.
            #endregion
            #region q3
            //double a = 5.5;
            //double b = 2.2;
            //double result = a / b + a;

            //Console.WriteLine( result);
            //The program works and gives the result, but floating-point may cause small precision errors
            #endregion
            #region q4
            //string text = "Hello World";
            //string sub = text.Substring(0, 5);
            //Console.WriteLine(sub);
            #endregion
            #region q5
            //int a = 10;
            //int b = a;
            //b = 20;
            //Console.WriteLine("a = " + a);
            //Console.WriteLine("b = " + b);
            //a=10 b=20  value type
            #endregion
            #region q6
            //MyClass obj1 = new MyClass();
            //obj1.Value = 10;

            //MyClass obj2 = obj1;
            //obj2.Value = 20;

            //Console.WriteLine("obj1.Value = " + obj1.Value);
            //Console.WriteLine("obj2.Value = " + obj2.Value);
            // Both will be 20
            #endregion
            #region q7
            //string first = "Hello ";
            //string second = "World";
            //string result = first + second;
            //Console.WriteLine(result);
            #endregion
            #region q8
            //double principal = 1000;
            //double rate = 5;
            //double time = 2;
            //double interest = (principal * rate * time) / 100;
            //Console.WriteLine("Simple Interest = " + interest);
            #endregion
            #region q9
            //double weight = 70;
            //double height = 1.75;
            //double bmi = weight / (height * height);
            //Console.WriteLine("BMI = " + bmi);
            #endregion
            #region q10
            //int temp = 25;
            //string result = temp < 10 ? "Just Cold" :
            //temp > 30 ? "Just Hot" : "Just Good";
            //Console.WriteLine(result);
            #endregion
            #region q11
            //int day = 20, month = 11, year = 2001;
            //Console.WriteLine($"Today's date : {day} , {month} , {year}");
            //Console.WriteLine($"Today's date : {day} / {month} / {year}");
            //Console.WriteLine($"Today's date : {day} - {month} - {year}");
            #endregion
            #region q12
            // The event is on 06/14/2024

            #endregion
            #region q13
            // A value 1 will be assigned to d.

            #endregion
            #region q14
            //16
            #endregion
            #region q15
            //7 7
            #endregion
        }
    }
}
