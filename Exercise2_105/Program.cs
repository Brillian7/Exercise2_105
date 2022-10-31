using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_105
{
    class Program
    {
        //definisikan array dengan ukuran maksimum 45
        private int[] BA = new int[45];
        //variable ukuran array
        private int n;
        //fungsi untuk menginputkan ukuran array
        public void read()
        {
            while(true)
            {
                Console.WriteLine("Masukkan jumlah element array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 45))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 45 elements.\n");

            }
        }

        static void Main(string[] args)
        {
        }
    }
}
