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



    }
}

