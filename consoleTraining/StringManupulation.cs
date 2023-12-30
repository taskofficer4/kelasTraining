using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleTraining
{
    internal class StringManupulation
    {
        static string wordReverse = string.Empty;
        static string wordReplace = string.Empty;
        static string wordQuote = string.Empty;
        static void s_Main()
        {
            //Reverse
            Console.WriteLine("Do Exercise string class");
            Console.WriteLine("\nInput Word To Reverse : ");
            wordReverse =  Console.ReadLine();
            Console.WriteLine("\nResult Of Reverse : " + f_wordReverse(wordReverse));

            //Replace Words
            Console.WriteLine("\nInput Word contains No Replace Yes : ");
            wordReplace = Console.ReadLine();
            Console.WriteLine("\nReplace Words : " + f_wordReplace(wordReplace));

            //Replace Quote Each Words
            Console.WriteLine("\nInput Quote Words : ");
            wordQuote = Console.ReadLine();
            Console.WriteLine("\nReplace Quote Each Words : " + f_wordReplaceQuotes(wordQuote));
        }

        static string f_wordReverse(string data)
        {            
            char[] s = data.ToCharArray();
            Array.Reverse((char[])s);
            return new string(s);
        }

        static string f_wordReplace(string data)
        {
            var res = string.Empty;
            if (data.Contains("no"))
                res = data.Replace("no", "yes");//.Split(' ');
            else
                res = data + "(words not contains (No))";
            return res;          
        }

        static string f_wordReplaceQuotes(string data)
        {
            var res = data.Split(' ');
            var stringNew = string.Empty;
            for (int i = 0; i < res.Length; i++)
            {
                var dummy = res[i];
                dummy = dummy.Replace(res[i], "'" + res[i] + "'" + ' ');
                stringNew += dummy;
            }
            return stringNew;
        }
    }
}
