using System;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);

            int n2 = 15;
            printSeries(n2);

            int n3 = 5;
            printTriangle(n3);

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);

            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            Console.WriteLine(r5);

            solvePuzzle();
        }

        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                Console.WriteLine("The self dividing numbers are:");
                int i = x;
                int[] SelfDN = new int[y];
                
                    while ((i >= x) && (i <= y))
                    {
                    string digit_string = i.ToString();
                    int len = digit_string.Length;
                    int c = 1;
                    int div = 0;
                    int[] remainders = new int[1];
                    int sum = 0;

                    while ((c >= 1) && (c <= len))
                        {
                        int digit = int.Parse(digit_string.Substring(c-1, 1));

                        if (digit == 0)
                                                       
                            {
                                sum += 1;
                                c++;
                            } 
                            else
                            {
                                div = i % digit;
                                    sum += div;
                                    c++;
                            }
                        }    // end of the second loop
                    
                     
                    if (sum == 0)
                       SelfDN[i-1] = i;
                    //end of if statement
                    i++;
                    } // end of the first loop        

                    
                    foreach (int z in SelfDN)
                    {
                    if (z != 0)
                        Console.WriteLine(z);
                   
                    }
                Console.WriteLine("\n");
            } // end of try

            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            } // end of catch
        }

        public static void printSeries(int n)
        {
            try
            {
                int[] alfa = new int[] { };

                for (int i = 1; i <= n; i++)
                {
                    int initial_elements = alfa.GetLength(0); //initial number of elements
                    Array.Resize(ref alfa, initial_elements + i);
                    int j = 1;
                    while ((j > 0) && (j <= i))
                    {
                        alfa.SetValue(i, initial_elements);
                        initial_elements++;
                        j++;
                    }

                    
                }
                int p = 1;
                while ((p > 0) && (p < n))
                {
                    Console.Write(alfa[p - 1] + ", ");
                    p++;
                }
                if (p == n)
                {
                    Console.Write(alfa[p - 1]);
                    Console.WriteLine("\n");
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

                int h = n;
                int b = (2 * h) - 1;
                int empty_spaces = 9 - b;
                int empty_left = empty_spaces / 2;
                int empty_right = empty_spaces / 2;

                while (h != 0)
                {
                    while (empty_left != 0)
                    {
                        Console.Write(" ");
                        empty_left--;
                    }
                    while (b != 0)
                    {
                        Console.Write("*");
                        b--;
                    }
                    while (empty_right != 0)
                    {
                        Console.Write(" ");
                        empty_right--;
                    }
                    Console.Write("\n");
                    h--;
                    b = (2 * h) - 1;
                    empty_spaces = 9 - b;
                    empty_left = empty_spaces / 2;
                    empty_right = empty_spaces / 2;

                }
                
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static int numJewelsInStones(int[] J, int[] S)
        {
            int count = 0;

            try
            {
                int elements = S.GetLength(0);
                int[] Jewels = new int[elements];
                

                foreach (int i in J)
                {
                    foreach (int x in S)
                    {
                        if (x == i)
                        {
                            count++;
                            Jewels[count - 1] = x;
                        }
                    }
                }

            }

            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return count;
        }

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {
                int[] z = new int[] { };
                int[] alfa = new int[] { };
                int count_z = 0;
                int count_alfa = 0;

                foreach (int i in a)
                {
                    foreach (int j in b)
                    {
                        int x = 1;
                            if (j == i)
                            {
                               Array.Resize(ref z, x);
                                z.SetValue(j, x-1);
                                x++;
                            }
                            else
                            {
                                Array.Clear(z, 0, count_z);
                            }


                        count_z = z.GetLength(0);
                        count_alfa = alfa.GetLength(0);
                        if (count_z > count_alfa)
                        {
                            Array.Resize(ref alfa, count_z);
                            alfa = z;
                        }
                            

                    }
                }
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
              
                
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }
}

