using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleTraining
{
    internal class taskRatna
    {

        enum Orientation : byte
        {
            north = 1,
            south = 2,
            east = 3,
            west = 4
        }

        struct Route 
        {
            public Orientation direction;
            public double distance;
        }

        internal static class XRatna
        {
            internal static void m_main()//Main(string[] args)
            {
                Console.WriteLine("The first app in Beginning C# and .NET!");
                // Console.WriteLine($"{args[0]}");
                Console.WriteLine("\n--Cetak bilangan sesuai Limit");
                int i = 1;
                while (i <= 10)
                {
                    if (i == 6)
                        break;
                    Console.WriteLine($"{i++}");
                }

                //bilangan Ganjil
                Console.WriteLine("\n--Bilangan Ganjil");
                int j;
                for (j = 1; j <= 10; j++)
                {
                    if ((j % 2) == 0)
                        continue;
                    Console.WriteLine(j);
                }

                // ENUM
                Console.WriteLine("\n--ENUM");
                byte directionByte;
                string directionString;
                Orientation myDirection1 = Orientation.north;
                Console.WriteLine($"myDirection = {myDirection1}");
                directionByte = (byte)myDirection1;
                directionString = myDirection1.ToString();// Convert.ToString(myDirection1);
                Console.WriteLine($"byte equivalent = {directionByte}");
                Console.WriteLine($"string equivalent = {directionString}");

                // STRUCT
                Console.WriteLine("\n--STRUCT");
                Route myRoute;
                int myDirection = -1;
                double myDistance;
                Console.WriteLine("1) North\n2) South\n3) East\n4) West");
                do
                {
                    Console.WriteLine("Select a direction:");
                    myDirection = Convert.ToInt32(Console.ReadLine());
                }
                while ((myDirection < 1) || (myDirection > 4));
                Console.WriteLine("Input a distance: ");
                myDistance = Convert.ToDouble(Console.ReadLine());
                myRoute.direction = (Orientation)myDirection;
                myRoute.distance = myDistance;
                Console.WriteLine($"myRoute specifies a direction of {myRoute.direction} " + $"and a distance of {myRoute.distance}");

                // Arrays
                Console.WriteLine("\n--ARRAYS Name");
                string[] friendNames = { "Todd Anthony", "Mary Chris", "Autry Rual" };
                int k;
                Console.WriteLine($"Here are {friendNames.Length} of my friends:");
                for (k = 0; k < friendNames.Length; k++)
                {
                    Console.WriteLine(friendNames[k]);
                }

                foreach (string friendName in friendNames)
                {
                    Console.WriteLine(friendName);
                }


                Console.WriteLine("\n--Switch Case di Foreach");
                foreach (string friendName in friendNames)
                {
                    switch (friendName)
                    {
                        case string t when t.StartsWith("T"):
                            Console.WriteLine("This friends name starts with a 'T': " +
                            $"{friendName} and is {t.Length - 1} letters long ");
                            break;
                        case string e when e.Length == 0:
                            Console.WriteLine("There is a string in the array with no value");
                            break;
                        case null:
                            Console.WriteLine("There was a 'null' value in the array");
                            break;
                        case var x:
                            Console.WriteLine("This is the var pattern of type: " +
                            $"{x.GetType().Name}");
                            break;
                        default:
                            break;
                    }
                }

                Console.WriteLine("\n--Arrays Int?");
                int sum = 0, total = 0, counter = 0, intValue = 0;                
                int?[] myIntArray = new int?[7] { 5, intValue, 9, 10, null, 2, 99 };
                foreach (var integer in myIntArray)
                {
                    switch (integer)
                    {
                        case 0:
                            Console.WriteLine($"Integer number '{counter}' has a default value of 0");
                            counter++;
                            break;
                        case int value:
                            sum += value;
                            Console.WriteLine($"Integer number '{counter}' has a value of {value}");
                            counter++;
                            break;
                        case null:
                            Console.WriteLine($"Integer number '{counter}' is null");
                            counter++;
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine($"The sum of all {counter} integers is {sum}");
                Console.ReadKey();
            }
        }
    }
}