using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
     class Program
    {
        //deklarasi array int dengan ukuran 38
        private int[] fann = new int[38];

        //Deklarasi variable int untuk menyimpan banyaknya data pada array
        private int n;
        public void read()
        {
            //Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.WriteLine("Masukkan Banyak Elemen pada Array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 38)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 38 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Masukkan elemen Array");
            Console.WriteLine("----------------------------------------------------------");

            //Pengguna Memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s = Console.ReadLine();
                fann[i] = Int32.Parse(s);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
