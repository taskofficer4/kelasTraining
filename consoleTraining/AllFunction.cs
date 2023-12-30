using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace consoleTraining
{
    /*
 FUNCTIONS
 Defining and Using Functions
 Return Values
 Parameters
 Parameter Matching
 Parameter Arrays
 Reference and Value Parameters
 Out Parameters
 Tuples
 Variable Scope
 Variable Scope in Other Structures
 Parameters and Return Values versus Global Data
 Local Functions
 The Main() Function
 Struct Functions
 Overloading Functions
 Using Delegates
 */
    internal class AllFunction
    {
        // Defining and Using Functions
        static void Write()
        {
            Console.WriteLine("OK");
        }

        // Return Values
        static double GetVal()
        {
            return 2.3;
        }

        // Parameters
        // Parameter Matching
        static int MaxValue(int[] intArray)
        {
            int maxVal = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxVal)
                    maxVal = intArray[i];
            }
            return maxVal;
        }


        static int SumVals2(int param1, int param2, int param3, params int[] vals)
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum += val;
            }
            return sum;
        }

        // Parameter Arrays
        static int SumVals(int[] vals)
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum += val;
            }
            return sum;
            //return 0;
        }


        // Reference and Value Parameters
        static void ShowDouble(ref int val)
        {
            val *= 2;
            Console.WriteLine($"val doubled = {val}");
        }

        // Out Parameters
        static int MaxValue(int[] intArray, out int maxIndex)
        {
            int maxVal = intArray[0];
            maxIndex = 0;
            //for (int i = 1; i < intArray.Length;)
            for(int i=1;;)
            {
                if (i < intArray.Length)
                    break;
                if (intArray[i] > maxVal)
                {
                    maxVal = intArray[i];
                    maxIndex = i;
                }

                i++;
            }
            return maxVal;
        }

        // Tuples
        private static (int max, int min, double average) GetMaxMin(IEnumerable<int> numbers)
        {
            return (Enumerable.Max(numbers),
                Enumerable.Min(numbers),
                Enumerable.Average(numbers));
        }

        // Variable Scope
        static string myString;

        // Parameters and Return Values versus Global Data
        static void Write2()
        {
            string myString = "String defined in Write2()";
            Console.WriteLine("Now in Write2()");
            Console.WriteLine($"Local myString = {myString}");
            Console.WriteLine($"Global myString = {AllFunction.myString}");
        }

        // Variable Scope in Other Structures
        struct CustomerName
        {
            public string firstName, lastName;
            // Struct Functions
            public string Name() => firstName + " " + lastName;
        }

        // Overloading Functions
        static double MaxValue(double[] doubleArray)
        {
            double maxVal = doubleArray[0];
            for (int i = 1; i < doubleArray.Length; i++)
            {
                if (doubleArray[i] > maxVal)
                    maxVal = doubleArray[i];
            }
            return maxVal;
        }

        // sing Delegates
        delegate double ProcessDelegate(double param1, double param2);
        static double Multiply(double param1, double param2) => param1 * param2;
        static double Divide(double param1, double param2) => param1 / param2;


        // The Main() Function
        static void Main(string[] args)
        {
            Write();
            double d = GetVal();
            Console.WriteLine(d);

            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            int maxVal = MaxValue(myArray);
            Console.WriteLine($"The maximum value in myArray is {maxVal}");
            
            //int num1 = 1, num2 = 2, num3 = 3, num4= 4;
            int[] myArray3 = {};
            int sum = SumVals(myArray3);
            Console.WriteLine($"Summed Values = {sum}");

            int sum2 = SumVals2(1, 2, 3);
            Console.WriteLine($"\nSummed Values ke 2 = {sum2}");

            int myNumber = 5;
            Console.WriteLine($"myNumber = {myNumber}");
            ShowDouble(ref myNumber);
            Console.WriteLine($"myNumber = {myNumber}");


            // int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            Console.WriteLine("The maximum value in myArray is " +
            $"{MaxValue(myArray, out int maxIndex)}");
            int getPositionNum = maxIndex;
            Console.WriteLine("The first occurrence of this value is " +
            $"at element {getPositionNum + 1}");

            var numbers1 = (1, 3, 5);
            var number = numbers1.Item1;
            Console.WriteLine($"numbers1.Item1 = {number}");

            (int one, int two, int three, int four, int five) nums = (1, 2, 3, 4,5);
            int first = nums.one;
            Console.WriteLine($"nums.one = {first}");

            IEnumerable<int> numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            var result = GetMaxMin(numbers);
            Console.WriteLine($"Max number is {result.max}, " +
            $"Min number is {result.min}, " +
            $"Average is {result.average}");


            string myString = "String defined in Main()";
            AllFunction.myString = "Global string";
            Write2();
            Console.WriteLine("\nNow in Main()");
            Console.WriteLine($"myString = {myString}");

            int myNumber2 = 5;
            Console.WriteLine($"Main Function = {myNumber2}");
            DoubleIt(myNumber2);
            Console.WriteLine($"Main Function = {myNumber2}");


            // Local Functions
            void DoubleIt(int val)
            {
                val *= 2;
                Console.WriteLine($"Local Function - val = {val}");
            }

            CustomerName myCustomer;
            myCustomer.firstName = "Rual";
            myCustomer.lastName = "Perkins";
            Console.WriteLine($"{myCustomer.firstName} {myCustomer.lastName}");
            Console.WriteLine(myCustomer.Name());

            double[] myArray2 = { 1.5, 8.5, 3.5, 6.5, 2.5, 5.5, 9.5, 3.5, 0.5, 2.5 };
            double maxVal2 = MaxValue(myArray2);
            Console.WriteLine($"The maximum value in myArray is {maxVal2}");


            ProcessDelegate process;
            Console.WriteLine("Enter 2 numbers separated with a comma:");
            string input = Console.ReadLine();
            int commaPos = input.IndexOf(',');
            double param1 = Convert.ToDouble(input.Substring(0, commaPos));
            double param2 = Convert.ToDouble(input.Substring(commaPos + 1, input.Length - commaPos - 1));
            Console.WriteLine("Enter M to multiply or D to divide:");
            input = Console.ReadLine();
            if (input == "M")
                process = new ProcessDelegate(Multiply);
            else
                process = new ProcessDelegate(Divide);
            Console.WriteLine($"Result: {process(param1, param2)}");


            Console.ReadKey();
        }
    }
}