﻿using System;

namespace Exec2
{
    class Program
    {
        //Array to be searched
        int[] ghani = new int[116];
        //Number of elements in the array
        int n;
        //geet the number of elements to store in the array
        int i;
        private int cmp_count = 0;//Number of comparassion
        private int mov_count = 0;//Number of data movements
        public void inputdata()
        {
            while (true)
            {   
                //Create insert of array
                Console.WriteLine("Masukan Nomor untuk elemen di dalam array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 116))
                    break;
                else
                    //Create a line for minimum 1 and maximum 116
                    Console.WriteLine("\n Array harus memiliki minimum 1 dan maximum 116 elemen. \n");
            }
            //Accept array elements
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine("  Enter Array elements ");
            Console.WriteLine("-----------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                ghani[i] = Int32.Parse(s1);
            }

        }

        public void BinarySerch()
        {
            char ch;
            do
            {
                //Accept the number to be searched
                Console.Write("\n Masukan elemen yang mau kamu cari : ");
                int item = Convert.ToInt32(Console.ReadLine());

                //Apply binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //Obtain the indext of the elements in the array 
                int mg = (upperbound + lowerbound) / 2;
                int ctr = 1;

                //Loop to search for the elements in the array
                while ((item != ghani[mg]) && (lowerbound <= upperbound))
                {
                    if (item > ghani[mg])
                        lowerbound = mg + 1;
                    else
                        upperbound = mg - 1;

                    mg = (upperbound + lowerbound) / 2;
                    ctr++;
                }
                if (item == ghani[mg])
                    Console.WriteLine("\n" + item.ToString() + "Terdapat di Posisi" + (mg + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "Tidak ada di dalam array\n");
                Console.WriteLine("\n Nomor Perbadingan : " + ctr);

                Console.Write("\n Lanjutkan mencari (y/n) : ");
                ch = char.Parse(Console.ReadLine());
                

            } while ((ch == 'y') || (ch == 'Y'));
        }
        public void LienarSearch()
        {
            char ch;
            //Search for number of comparisson
            int ctr;
            do
            {

            }
        }
    }
}

