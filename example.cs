using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_1
{
    internal class Program
    {
        //question 1
        public static void swapTwoNumber(int a, int b)
        {


            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swap : ");
            Console.WriteLine($"First is {a}");
            Console.WriteLine($"Second is {b}");
        }
        //question 2
        public static void mul(int p, int q, int r)
        {
            int mulValue = p * q * r;
            Console.WriteLine($"Expected Output : \n {p} * {q} * {r} = {mulValue}");
        }
        //question 3
        public static void addDivSubMul(int a1, int a2)
        {
            Console.WriteLine("Expected Output : \n ");
            int addValue = a1 + a2;
            Console.WriteLine($"{a1} + {a2} = {addValue} ");
            int subValue = a1 - a2;
            Console.WriteLine($"{a1} - {a2} = {subValue}");
            int mulValue = a1 * a2;
            Console.WriteLine($"{a1} * {a2} = {mulValue}");
            int divValue = a1 / a2;
            Console.WriteLine($"{a1} / {a2} = {divValue}");
            int modValue = a1 % a2;
            Console.WriteLine($"{a1} mod {a2} = {modValue}");
        }
        // question 4
        public static void mulThreeValue(int x, int y, int z)
        {
            Console.WriteLine("Expected Output : ");
            int value = (x + y) * z;
            Console.WriteLine($"(x+y)*z is {value}");
            int value2 = x * y + y * z;
            Console.WriteLine($"x*y + y*z is {value2}");
        }
        // question 5
        public static void minMax(int x1, int x2)
        {
            Console.WriteLine("Output : ");
            if (x1 > x2)
                Console.WriteLine("Fisrt Number is greater than Second Number");
            else
                Console.WriteLine("Fisrt Number is smaller than Second Number");
        }
        // question 6
        public static void totalMarksPercentage(int m1, int m2, int m3)
        {
            Console.WriteLine("Output : ");
            int totalMarks = m1 + m2 + m3;
            int percentage = totalMarks / 3;
            if (percentage > 60)
                Console.WriteLine("First");
            else if (percentage > 45 && percentage < 60)
                Console.WriteLine("Second");
            else if (percentage > 45 && percentage < 35)
                Console.WriteLine(" Third ");
            else
                Console.WriteLine("Fail");
        }
        // question 7
        public static void printNumberWithSpace(int n)
        {
            Console.WriteLine("Output : ");
            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine($"{n} {n} {n} {n}");
                Console.WriteLine($"{n}{n}{n}{n}");
            }
        }
        // question 8
        public static void celciusToFarhenhite(Double cel)
        {
            Console.WriteLine("Expected Output ");
            Double kelvin = cel + 273.15;
            Console.WriteLine($"Kelvin = {kelvin}");
            Double faren = (cel * 9 / 5) + 32;
            Console.WriteLine($"Fahrenheit = {faren}");

        }
        // question 9
        public static void sumOfTwoGivenInteger(int num1, int num2)
        {
            Console.WriteLine("Output : ");
            if (num1 != num2)
            {
                int numberValue = num1 + num2;
                Console.WriteLine($"The sum of two numbers are : {numberValue}");
            }
            else
            {
                int TripleValue = num1 * 3;
                Console.WriteLine($"Two numbers are equal {TripleValue} ");
            }
        }
        //question 10
        public static void absoluteValue(Double val1, Double val2)
        {
            Console.WriteLine("Output : ");
            Double absoluteDifference = Math.Abs(val1 - val2);

            if (val1 > val2)
            {
                Double result = 2 * absoluteDifference;
                Console.WriteLine($"The absolute difference is {absoluteDifference}, and double the absolute difference is  {result}");

            }
            else
            {
                Console.WriteLine($"The absolute difference is  {absoluteDifference}");
            }
        }
        // question 11
        public static void daysIntoYears(int totalDays)
        {
            Console.WriteLine("Output");
            int years = totalDays / 365;
            int remainingDays = totalDays % 365;
            int weeks = remainingDays / 7;
            int days = remainingDays % 7;
            Console.WriteLine($"{totalDays} days is equal to: {years} year {weeks} weeks {days} days");
        }






        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the First number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            swapTwoNumber(a, b);

            question 2
            Console.WriteLine("\n*****************************************************\n");
            Console.WriteLine("Enter the First number to Multiply : ");
            int p = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the Second number to Multiply : ");
            int q = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number to Multiply : ");
            int r = Convert.ToInt32(Console.ReadLine());
            mul(p, q, r);


            question 3
            Console.WriteLine("\n*****************************************************\n");
            Console.WriteLine("Input the First number : ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            addDivSubMul(a1, a2);

            question 4
            Console.WriteLine("Enter first number - ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number - ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number - ");
            int z = Convert.ToInt32(Console.ReadLine());
            mulThreeValue(x, y, z);

            question 5
            Console.WriteLine("Enter First number : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            minMax(x1, x2);

            question 6
            Console.WriteLine("Enter first sub marks : ");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second sub marks : ");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third sub marks : ");
            int m3 = Convert.ToInt32(Console.ReadLine());

            totalMarksPercentage(m1, m2, m3);

            question 7
            Console.WriteLine("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            printNumberWithSpace(n);

            question 8
            Console.Write("Enter the amount of celcius - ");
            Double cel = Convert.ToDouble(Console.ReadLine());
            celciusToFarhenhite(cel);

            question 9
            Console.Write("Enter First number - ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number - ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            sumOfTwoGivenInteger(num1, num2);

            question 10
            Console.Write("Enter the first number: ");
            Double val1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            Double val2 = Convert.ToDouble(Console.ReadLine());

            absoluteValue(val1, val2);

            question 11

            Console.Write("Enter the number of days: ");
            int totalDays = Convert.ToInt32(Console.ReadLine());

            daysIntoYears(totalDays);



            Console.ReadLine();
        }
    }
}

