using System;

namespace arrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayA = new double[5];
            double[,] arrayB = new double[3, 4];

            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                //double number = double.Parse();
                arrayA[i] = double.Parse(Console.ReadLine());
            }


            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arrayB[i, j] = rand.Next();
                }
            }

            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.Write($"{arrayA[i]}");
                Console.Write(" ");
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{arrayB[i, j]}");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }


            // №2
            int[] arrayM = new int[10];
            int[] arrayN = new int[8];
            int size = 0;

            for (int i = 0; i < arrayM.Length; i++)
            {
                arrayM[i] = rand.Next(0, 20);
            }

            for (int i = 0; i < arrayM.Length; i++)
            {
                Console.Write($"{arrayM[i]}");
                Console.Write(" ");
            }
            Console.WriteLine();

            for (int i = 0; i < arrayN.Length; i++)
            {
                arrayN[i] = rand.Next(0, 20);
            }

            for (int i = 0; i < arrayN.Length; i++)
            {
                Console.Write($"{arrayN[i]}");
                Console.Write(" ");
            }
            Console.WriteLine();

            for (int i = 0; i < arrayM.Length; i++)
            {
                for (int j = 0; j < arrayN.Length; j++)
                {
                    if (arrayN[j] == arrayM[i])
                    {
                        size++;
                        break;
                    }
                }
            }

            int[] arrayOfCommonElements = new int[size];

            int tmp = 0;
            for (int i = 0; i < arrayM.Length; i++)
            {
                for (int j = 0; j < arrayN.Length; j++)
                {
                    if (arrayN[j] == arrayM[i])
                    {
                        arrayOfCommonElements[tmp] = arrayN[j];
                        tmp++;
                        break;
                    }
                }
            }

            for (int i = 0; i < arrayOfCommonElements.Length; i++)
            {
                Console.Write($"{arrayOfCommonElements[i]}");
                Console.Write(" ");
            }
            Console.WriteLine();

            // №3
            string palindromString;
            bool isPalindrom = false;
            Console.WriteLine("Enter string: ");
            palindromString = Console.ReadLine();
            palindromString = palindromString.ToLower();

            for (int i = 0; i < palindromString.Length / 2; i++)
            {
                if (palindromString.Length % 2 != 0)
                {
                    break;
                }
                else
                {
                    if (palindromString[i] == palindromString[palindromString.Length - i - 1])
                    {
                        isPalindrom = true;
                    }
                    else
                    {
                        isPalindrom = false;
                        break;
                    }
                }
            }

            if (isPalindrom)
            {
                Console.WriteLine("It is palindrom");
            }
            else
            {
                Console.WriteLine("It is not palindrom");
            }

            // №4
            string sString;
            int count = 0;
            Console.WriteLine("Enter string: ");
            sString = Console.ReadLine();

            for (int i = 0; i < sString.Length; i++)
            {
                if (sString[i] == ' ')
                {
                    count++;
                }
            }
            count++;

            Console.WriteLine($"Word count = {count}");

            // №5
            const int ARRAY_SIZE = 5;
            int[,] array = new int[ARRAY_SIZE, ARRAY_SIZE];
            int minElement = 0;
            int maxElement = 0;
            int minI = 0, maxI = 0;
            int minJ = 0, maxJ = 0;
            int amountOfElements = 0;

            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                for (int j = 0; j < ARRAY_SIZE; j++)
                {
                    array[i, j] = rand.Next(-100, 100);
                }
            }

            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                for (int j = 0; j < ARRAY_SIZE; j++)
                {
                    if (array[i, j] < minElement)
                    {
                        minElement = array[i, j];
                        minI = i;
                        minJ = j;
                    }

                    if (array[i, j] > maxElement)
                    {
                        maxElement = array[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                }
            }

            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                for (int j = 0; j < ARRAY_SIZE; j++)
                {
                    Console.Write($"{array[i, j]}");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            if (minI < maxI)
            {
                for (int i = minI; i < maxI; i++)
                {
                    for (int j = 0; j < ARRAY_SIZE; j++)
                    {
                        amountOfElements += array[i, j];
                    }
                }
            }
            else
            {
                for (int i = maxI; i < minI; i++)
                {
                    for (int j = 0; j < ARRAY_SIZE; j++)
                    {
                        amountOfElements += array[i, j];
                    }
                }
            }

            for (int j = 0; j < minJ; j++)
            {
                amountOfElements -= array[minI, j];
            }

            Console.WriteLine($"The amount of elements = {amountOfElements}");

        }


    }
}
