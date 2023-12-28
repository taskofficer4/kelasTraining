using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleTraining
{
    internal class Calculator : taskRatna
    {
        public static void c_Main(string[] args)
        {
            var opsi = string.Empty;
            var aksi = string.Empty;
            double angka1, angka2, hasil;

        repeat:
            Console.Clear();
            Console.WriteLine("\n\nPilih Operasi Kalkulator :");
            Console.WriteLine("1.Penjumlahan\n2.Pengurangan\n3.Perkalian\n4.Pembagian\n\nMasukan Opsi : ");
            opsi = Console.ReadLine();

            Console.WriteLine("Masukan Angka Pertama :");
            angka1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukan Angka Kedua :");
            angka2 = Convert.ToDouble(Console.ReadLine());
            hasil = operasi(angka1, angka2, opsi);
            Console.WriteLine($"Hasil {kode(opsi)} ({angka1} & {angka2}) =  {hasil}");

            Console.WriteLine("\nApakah anda ingin melanjutkan (Y/N):");
            aksi = Console.ReadLine();
            if (aksi.Equals("y", StringComparison.InvariantCultureIgnoreCase) && !string.IsNullOrEmpty(aksi))
                goto repeat;
            else
                Environment.Exit(0);
        }

        private static double operasi(double a, double b, string code)
        {
            switch (code)
            {
                case "1":
                    return a + b;
                case "2":
                    return a - b;
                case "3":
                    return a * b;
                default:
                    return a / b;
            }
        }

        private static string kode(string code)
        {
            switch (code)
            {
                case "1":
                    return "Penjumlahan";
                case "2":
                    return "Pengurangan";
                case "3":
                    return "Perkalian";
                default:
                    return "Pembagian";
            }
        }
    }
}