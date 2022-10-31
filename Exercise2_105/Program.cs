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
        private int[] Bril = new int[45];
        //variable ukuran array
        private int n;
        private int i;

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
            //accept array elements
            Console.WriteLine("");
            Console.WriteLine("=====================================");
            Console.WriteLine(" Enter Array Elements");
            Console.WriteLine("=====================================");

            //user inputs for the array
            for(i=0; i<n;i++)
            {
                Console.Write("<" + (i+1) + ">");
                string s1 = Console.ReadLine();
                Bril[i] = Int32.Parse(s1);
            }

        }

        public void binarysearch()
        {
            
            
            {
                //accept the number to be searched
                Console.Write("\nenter element want you to search :");
                int item = Convert.ToInt32(Console.ReadLine());

                //apply binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                
                
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
