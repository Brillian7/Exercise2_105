using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgoritma_105
{
    class Program
    {
        //Array to be searched
        int[] Bril = new int[45];
        //Number of elements in the array
        int n;
        //Get the number of elements to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 45))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 45 elements.\n");
            }
            //Accept array elements
            Console.WriteLine("");
            Console.WriteLine("==========================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("==========================");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                Bril[i] = Int32.Parse(s1);
            }
        }

        public void BinarySearch()
        {
            char ch;
            do
            {
                //accept the number to be searched
                Console.Write("\nEnter Element want you to search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                // apply binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //obtain the index of the middle elements
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                // loop to search for the elements in the array
                while ((item != Bril[mid]) && (lowerbound <= upperbound))
                {
                    if (item > Bril[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == Bril[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at position" + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + " not found in the array\n");
                Console.WriteLine("\nNumber of comparasion : " + ctr);

                Console.Write("\nContinue search (y/n):");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }

        public void LinearSearch()
        {
            char ch;
            //search for number of comparison
            int ctr;
            do
            {
                //Accept the number to be searched 
                Console.Write("\nEnter the Element you want to search: ");
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (Bril[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + "found st position" + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("\n" + item.ToString() + " not found in the array");
                Console.WriteLine("\nNumber of comparasion : " + ctr);
                Console.Write("\nContinue search (y/n):");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            do
            {
                Console.WriteLine("Menu Option");
                Console.WriteLine("=================");
                Console.WriteLine("1. Linear Search ");
                Console.WriteLine("2. Binary Search ");
                Console.WriteLine("3. EXIT ");
                Console.Write("Enter your choice (1,2,3) : ");
                pilihanmenu = Convert.ToInt32(Console.ReadLine());

                switch (pilihanmenu)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("...................................");
                        Console.WriteLine("Linear Search");
                        Console.WriteLine("...................................");
                        myList.input();
                        myList.LinearSearch();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("...................................");
                        Console.WriteLine("Binary Search");
                        Console.WriteLine("...................................");
                        myList.input();
                        myList.BinarySearch();
                        break;
                    case 3:

                        Console.WriteLine("EXIT.");
                        break;
                }
                //to exit from the console
                Console.WriteLine("\n\nPress return to exit.");
                Console.ReadLine();
            } while (pilihanmenu != 3);
        }
    }
}
