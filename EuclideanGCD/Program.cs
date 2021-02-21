using System;

namespace EuclideanGCD
{
    static class CalculationGCD
    {
        public static int CalculateGCD(int numberA, int numberB)
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
        public static int CalculateGCD(int numA, int numB, int numC)
        {
            int first = CalculateGCD(numA, numB);
            int second = CalculateGCD(numB, numC);
            if (first != second)
            {
                return CalculateGCD(first, second);
            }
            return first;
        }
        public static int CalculateGCD(int numA, int numB, int numC, int numD)
        {
            int first = CalculateGCD(numA, numB, numC);
            int second = CalculateGCD(numB, numC, numD);
            if (first != second)
            {
                return CalculateGCD(first, second);
            }
            return first;
        }
        public static int CalculateGCD(int numA, int numB, int numC, int numD, int numE)
        {
            int first = CalculateGCD(numA, numB, numC);
            int second = CalculateGCD(numC, numD, numE);
            if (first != second)
            {
                return CalculateGCD(first, second);
            }
            return first;
        }
    }
    class Program
    {
        private static int[] InputNumbers()
        {
            Console.WriteLine("Enter numbers: ");
            string line = Console.ReadLine();
            string[] srtArray = line.Split(',');
            return Array.ConvertAll(srtArray, int.Parse);
        }
        private static int FindMethod(int[] myList)
        {
            int length = myList.Length;
            switch (length)
            {
                case 3:
                    return CalculationGCD.CalculateGCD(myList[0], myList[1], myList[2]);
                case 4:
                    return CalculationGCD.CalculateGCD(myList[0], myList[1], myList[2], myList[3]);
                case 5:
                    return CalculationGCD.CalculateGCD(myList[0], myList[1], myList[2], myList[3], myList[4]);
                default:
                    break;
            }
            return CalculationGCD.CalculateGCD(myList[0], myList[1]);
        }
        static void Main()
        {
            int[] numbersList = InputNumbers();
            int result = FindMethod(numbersList);
            Console.WriteLine($"GCD is: {result}");
        }
    }
}

