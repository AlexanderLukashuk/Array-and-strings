using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // №1
            char[] stringWithoutDot = new char[10000];
            char tmp;
            string symbol;
            int countOfSpace = 0;
            int counter = 0;

            while (true)
            {
                Console.WriteLine("Enter symbol: ");
                symbol = Console.ReadLine();
                if (symbol == ".")
                {
                    break;
                }

                if (symbol == " ")
                {
                    countOfSpace++;
                }
                stringWithoutDot[counter] = char.Parse(symbol);
                counter++;
            }

            Console.WriteLine($"Count of space = {countOfSpace}");

            // №2
            string input;
            int luckyTicket;
            int firstThreeDigits = 0;
            int lastThreeDigits = 0;
            int tmp1, tmp2;

            while (true)
            {
                Console.Write("Enter 6 digit number: ");
                input = Console.ReadLine();
                luckyTicket = int.Parse(input);

                if (luckyTicket / 100000 > 0 && luckyTicket / 100000 < 10)
                {
                    break;
                }
            }

            tmp1 = luckyTicket % 10;
            lastThreeDigits += tmp1;
            tmp2 = (luckyTicket % 100) / 10;
            lastThreeDigits += tmp2;
            lastThreeDigits += (luckyTicket % 1000) / 100;

            firstThreeDigits += luckyTicket / 100000;
            firstThreeDigits += (luckyTicket / 10000) % 10;
            firstThreeDigits += (luckyTicket / 1000) % 10;

            //Console.WriteLine($"{luckyTicket}");
            //Console.WriteLine($"{lastThreeDigits}");
            //Console.WriteLine($"{firstThreeDigits}");

            if (firstThreeDigits == lastThreeDigits)
            {
                Console.WriteLine("It is a lucky ticket");
            }
            else
            {
                Console.WriteLine("It is not a lucky ticket");
            }

            // №3
            char[] transferToAnotherRegister = new char[10000];
            int tmpSymbol;
            counter = 0;

            while (true)
            {
                Console.WriteLine("Enter '.' to finish");
                Console.WriteLine("Enter symbol: ");
                tmpSymbol = Console.Read();
                //Console.WriteLine();

                if (tmpSymbol >= 65 && tmpSymbol <= 90)
                {
                    tmpSymbol += 32;
                    transferToAnotherRegister[counter] = (char)tmpSymbol;
                    counter++;
                }
                else if (tmpSymbol >= 97 && tmpSymbol <= 122)
                {
                    tmpSymbol -= 32;
                    transferToAnotherRegister[counter] = (char)tmpSymbol;
                    counter++;
                }
                else if (tmpSymbol == 46)
                {
                    break;
                }
            }

            for (int i = 0; i < transferToAnotherRegister.Length; i++)
            {
                Console.Write($"{transferToAnotherRegister[i]}");
            }
            Console.WriteLine();
            Console.ReadLine();

            // №4
            int numberA, numberB;
            Console.Write("Enter number A: ");
            input = Console.ReadLine();
            numberA = int.Parse(input);

            Console.Write("Enter number B: ");
            input = Console.ReadLine();
            numberB = int.Parse(input);

            if (numberA < numberB)
            {
                for (int i = numberA; i <= numberB; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write($"{i}");
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = numberB; i <= numberA; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write($"{i}");
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

            // №5
            int numberN;
            Console.Write("Enter number N(>0): ");
            input = Console.ReadLine();
            numberN = int.Parse(input);

            int tmpNumber1 = -1;
            int tmpNumber2 = numberN;
            numberN = 0;

            while (tmpNumber1 != 0)
            {
                tmpNumber1 = tmpNumber2 % 10;
                numberN += tmpNumber1;
                numberN *= 10;
                tmpNumber2 /= 10;
            }
            numberN /= 10;
            numberN /= 10;

            Console.WriteLine($"New Number N = {numberN}");

        }
    }
}
