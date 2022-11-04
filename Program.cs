using System;

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

        public void BinarySearch()
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
        public void LinearSearch()
        {
            char ch;
            //Search for number of comparisson
            int ctr;
            do
            {
                //accept the number to be searched
                Console.Write("\n Masuka elemen yang kamu cari: ");
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (ghani[i] == item)
                    {
                        Console.Write("\n" + item.ToString() + "Posisi Didapatkan" + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("\n" + item.ToString() + "Not found in the array");
                Console.WriteLine("\n Nomor untuk perbandingan : " + ctr);
                Console.WriteLine("\n Lanjutkan mencari ? (y/n): ");
                ch = char.Parse(Console.ReadLine());

            } while ((ch == 'y') || (ch == 'Y'));
        }
        static void Main(string[] args)
        {
            Program mylist = new Program();
            int pilihanmenu;
            char ch;

            Console.WriteLine("Menu option");
            Console.WriteLine("===============");
            Console.WriteLine(" 1. Linear Search");
            Console.WriteLine(" 2. Binary Search");
            Console.WriteLine(" 3. Exit");
            Console.WriteLine(" Ketik pilihanmu (1,2,3) :");
            pilihanmenu = Convert.ToInt32(Console.ReadLine());
            switch (pilihanmenu)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("------------------");
                    Console.WriteLine("Linear Search");
                    Console.WriteLine("------------------");
                    mylist.inputdata();
                    mylist.LinearSearch();
                    break;
               case 2:
                    Console.WriteLine("");
                    Console.WriteLine("------------------");
                    Console.WriteLine(" Binary Search");
                    Console.WriteLine("------------------");
                    mylist.inputdata();
                    mylist.BinarySearch();
                    break;
                case 3:
                    Console.WriteLine(" Exit ");
                    break;
                default:
                    Console.WriteLine(" Error ");
                    break;
            }
        }
    }
}

