﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
     class Program
    {
        //deklarasi array int dengan ukuran 38
        public int[] fann = new int[38];


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
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(" Element array yang tersusun");
            Console.WriteLine("----------------------------------------------");
            for (int mm = 0; mm < n; mm++)
            {
                Console.WriteLine(fann[mm]);

            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++)
            {
                //pada spasi i, bandingkan n -1 elemenn pertama dengan elemen selanjutnya
                for (int mm = 0; mm < n - i; mm++)
                {
                    if (fann[mm] > fann[mm + 1]) //jika elemen tidak ada dalam ururtan  yang benar
                    {
                        //tukar elemen
                        int temp;
                        temp = fann[mm];
                        fann[mm] = fann[mm + 1];
                        fann[mm + 1] = temp;

                    }
                }
            }
        }
        public void input()
        {
            int n;
            // get the number of element to store in the array
            int i;

            while (true)
            {
                Console.Write("Enter the number elements in the array  ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 38))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elemets.\n");
            }
            // accpect array element
            Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            Console.WriteLine(" Enter array elements ");
            Console.WriteLine("-----------------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                fann[i] = Int32.Parse(s1);
            }

        }
        public void BinarySearch()
        {
            char ch;
            do
            {

                //accpect the number to be searched 
                Console.Write("\nEnter element want you to Search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                //applt binary search
                int low = 0;
                int high = n - 1;

                //obtain the index of the middle elemets
                int mid = (low + high) / 2;
                int ctr = 1;

                //loop to search for the elements in the array 
                while ((item != fann[mid]) && (low <= high))
                {
                    if (item > fann[mid])
                        low = mid + 1;
                    else
                        high = mid - 1;
                    mid = (low + high) / 2;
                    ctr++;
                }
                if (item == fann[mid])
                    Console.WriteLine("\n" + item.ToString() + "Found at position" + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "Not Found in the array \n");
                Console.WriteLine("\nNumber of comprasion : " + ctr);

                Console.Write("\nContinue search (y/n) : ");
                ch = char.Parse(Console.ReadLine());

            } while ((ch != 'y') || (ch == 'y'));

        }

        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmu;
            do
            {
                Console.WriteLine("Menu option");
                Console.WriteLine("======================");
                Console.WriteLine("1.Bubble Search");
                Console.WriteLine("2.Binary Search ");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter Your choice(1,2,3): ");
                pilihanmu = Convert.ToInt32(Console.ReadLine());
                switch (pilihanmu)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("................");
                        Console.WriteLine("Bubble Search");
                        Console.WriteLine("................");
                        myList.input();
                        myList.BubbleSortArray();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("................");
                        Console.WriteLine("Binary Search");
                        Console.WriteLine("................");
                        myList.input();
                        myList.BinarySearch();
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                //to exit from the console
                Console.WriteLine("\n\nPress Return to exit.");
                Console.ReadLine();
            } while (pilihanmu != 3);
        }
    }
}
