using System;
//using System.Collections.Generic;

namespace EuclideanGCD
{
    static class CalculationGCD
    {
        internal static int CalculateGCD(int numberA, int numberB)
        {
            while (numberA != 0 && numberB != 0)
            {
                if (numberA > numberB)
                {
                    numberA %= numberB;
                }
                else
                {
                    numberB %= numberA;
                }
            }
            return numberA + numberB;
        }
        internal static int CalculateGCD(int numA, int numB, int numC)
        {
            int first = CalculateGCD(numA, numB);
            int second = CalculateGCD(numB, numC);
            if (first != second)
            {
                return CalculateGCD(first, second);
            }
            return first;
        }
        internal static int CalculateGCD(int numA, int numB, int numC, int numD)
        {
            int first = CalculateGCD(numA, numB, numC);
            int second = CalculateGCD(numB, numC, numD);
            if (first != second)
            {
                return CalculateGCD(first, second);
            }
            return first;
        }
        //переписать
        internal static int CalculateGCD(int numA, int numB, int numC, int numD, int numE)
        {
            int first = CalculateGCD(numA, numB, numC);
            int second = CalculateGCD(numC, numD, numE);
            return first == second ? first : 1;
        }
    }
    class Program
    {
        /*
         public static List<int> InputNumbers()
         {
             List<int> list = new List<int>();
             Console.WriteLine("Enter first number: ");
             string line = Console.ReadLine();
             while (line != string.Empty)
             {
                 list.Add(int.Parse(line));
                 Console.WriteLine("Enter next number:");
                 line = Console.ReadLine();
             }
             return list;
         }
        */
        public static int[] InputNumbers()
        {
            Console.WriteLine("Enter numbers: ");
            string line = Console.ReadLine();
            string[] srtArray = line.Split(' ');
            return Array.ConvertAll(srtArray, int.Parse);
        }
        public static int FindMethode(int[] myList)
        {
            int length = myList.Length;
            if (length == 3)
            {
                return CalculationGCD.CalculateGCD(myList[0], myList[1], myList[2]);
            }
            if (length == 4)
            {
                return CalculationGCD.CalculateGCD(myList[0], myList[1], myList[2], myList[3]);
            }
            if (length == 5)
            {
                return CalculationGCD.CalculateGCD(myList[0], myList[1], myList[2], myList[3], myList[4]);
            }
            return CalculationGCD.CalculateGCD(myList[0], myList[1]);
        }
        static void Main()
        {
            int[] numbersList = InputNumbers();
            int result = FindMethode(numbersList);
            Console.WriteLine($"GCD is: {result}");
        }
    }
}

