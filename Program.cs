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
                Console.WriteLine("Masukan Nomor untuk elemen di dalam array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 116))
                    break;
                else
                    Console.WriteLine("\n Array harus memiliki minimum 1 dan maximum 116 elemen. \n");
            }
        }

    }
}

