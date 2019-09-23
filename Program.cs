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

            int n3 = 5;
            printTriangle(n3);

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);

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
                Console.WriteLine("The self-divisible numbers between " + x + " and " + y + " are :");
                foreach (int value in list_store)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }

            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }

        public static void printSeries(int n)
        {
            Console.WriteLine();
            try
            {
                int counter = 0;
                for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; (j <= i && counter < n); j++ )
                        {
                            Console.Write(i);
                        if (counter < n - 1) // To avoid getting "," at end of string
                            Console.Write(", ");
                            counter++;
                        }

                    }
                Console.WriteLine();

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
                Console.WriteLine();
                for (int i = n; i > 0; i--)
                {
                    for (int j = 0; j < n - i; j++)

                    {
                        Console.Write(" ");

                    }
                    for (int j = 0; j < (i * 2) - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
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
                int[] jewels_array = new int[S.Length];
                int count = 0;
                for (int i = 0; i < J.Length; i++)
                {
                    for (int j = 0; j < S.Length; j++)
                    {
                        if (J[i] == S[j])
                        {
                            jewels_array[count] = S[j];
                            count++;

                        }
                    }
                }
                if (count != 0)
                {
                    Console.Write(count + " (since ");
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(jewels_array[i] + " ");
                    }
                    Console.WriteLine(" are jewels)");
                }
                else
                {
                    Console.WriteLine(count);
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }
            Console.WriteLine();

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

