using System;

namespace SimpleFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static double ToFaringate(double celsius)
        {
            return celsius * 1.8 + 32;
        }
        static bool IsPalindrom(string myWord)
        {
            for (int i = 0, j = myWord.Length - 1; i < j; i++, j--)
            {
                if (myWord[i] != myWord[j])
                {
                    return false;
                }
            }
            return true;
        }
        static int GetSummElement(int[] array)
        {
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            return summ;
        }
        static int CountDigit(int number)
        {
            int count = 1;
            while (number > 9)
            {
                count++;
                number = number / 10;
            }
            return count;
        }
        static string GetAddress(string city, string street, int house, int flat)
        {
            return ($"city:{city}, street:{street}, house: {house}, flat:{flat}");
        }
        static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }
        static int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
        static int GetCountContains(string line, char symbol)
        {
            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (symbol == line[i])
                {
                    count++;
                }
            }
            return count;
        }
        static void SwapDigit(ref int numberOne, ref int numberTwo)
        {
            int a = numberOne;
            numberOne = numberTwo;
            numberTwo = a;
        }
        static void SwapSting(ref string word1, ref string word2)
        {
            string refWord = word1;
            word1 = word2;
            word2 = refWord;
        }
        static void SwapChar(ref char simbol1, ref char simbol2)
        {
            char refChar = simbol1;
            simbol1 = simbol2;
            simbol2 = refChar;
        }
    }
}
