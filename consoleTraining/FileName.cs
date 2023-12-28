using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleTraining
{
    internal class FileName
    {
        static void f_Main(string[] args)
        {
            Console.WriteLine("OK");

            string myString = "A string";
            char[] myChars = myString.ToCharArray();

            foreach (char character in myString)
            {
                Console.WriteLine($"{character}");
            }
            Console.WriteLine($"{myString.ToLower()}");
            Console.WriteLine($"{myString.ToUpper()}");

            foreach (char character in myChars)
            {
                Console.WriteLine($"{character}");
            }
            myString = "Aligned";
            myString = myString.PadLeft(10, '-');
            Console.WriteLine($"{myString}");

            myString = "This is a test.";
            char[] separator = { ' ' };
            string[] myWords;
            myWords = myString.Split(separator);
            foreach (string word in myWords)
            {
                Console.WriteLine($"{word}");
            }
            Console.WriteLine($"{myWords.Length}");
           // Array.Reverse(myWords);
            char[] s = myString.ToCharArray();
            Array.Reverse(s);
            Console.WriteLine($"{Convert.ToString(s)}");
            //Console.ReadKey();
            Console.WriteLine($"{wordReverse()}");
            //var s = myString.Reverse();
            Console.WriteLine($"{wordReplace()}");
        }

        static string wordReverse()
        {
            var k = "aku kamu kita";
            char[] s = k.ToCharArray();
            Array.Reverse((char[])s);
            return new string(s);
        }

        static string wordReplace()
        {
            var k = "nonton bareng sama teman teman";
            var s = k.Replace("no", "yes").Split(' ');
            var n = string.Empty;
            for(int i=0;i<s.Length;i++)
            {
                var data = s[i];
                data = data.Replace(s[i], "'" + s[i] + "'" + ' ');
                n += data;
            }
            return n ;
        }
    }
}
