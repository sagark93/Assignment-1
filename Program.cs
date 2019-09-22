using System;
using System.Collections.Generic;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);

            int n2 = 5;
            printSeries(n2);

            //int n3 = 5;
            //printTriangle(n3);

            //int[] J = new int[] { 1, 3 };
            //int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            //int r4 = numJewelsInStones(J, S);
            //Console.WriteLine(r4);

            //int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            //int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            //int[] r5 = getLargestCommonSubArray(arr1, arr2);
            //Console.WriteLine(r5);

            //solvePuzzle();
        }


        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                //int[] list = new int[y];
                List<int> list_store = new List<int>();

                bool selfDividing(int n)
                {
                    int i = n;
                    while (n > 0)
                    {
                        int d = n % 10;
                        n /= 10;
                        if (d == 0 || (i % d) > 0)
                            return false;
                    }
                    return true;

                }

                for (int j = x; j <= y; j++)
                {
                    if (selfDividing(j))
                        list_store.Add(j); 
                }
                Console.WriteLine("The self-divisible numbers between " + x + " and " + y + " zare :");
                foreach (int value in list_store)
                {
                    Console.WriteLine(value);
                }

            }

            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }

        public static void printSeries(int n)
        {
            try
            {
                int limit = 5;
                int counter = 0;
                for (int i = 1; i <= limit; i++)
                    {
                        for (int j = 1; (j <= i && counter < limit); j++ )
                        {
                            Console.Write(i);
                        if (counter < limit - 1)
                            Console.Write(", ");
                            counter++;
                        }
                                

                    }
           }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            return null; // return the actual array
        }

        public static void solvePuzzle()
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }
}

