using System;

namespace SimpleFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите два слова: ");
            string word = Console.ReadLine();
            string word2 = Console.ReadLine();
            bool isAnagramm = IsAnagramm(word, word2);
            Console.WriteLine(isAnagramm);
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
        static void GenEvenNumb(out int result)
        {
            Random rnd = new Random();
            result = rnd.Next(0, 100);
            if (result % 2 != 0)
            {
                result += 1;
            }
            Console.WriteLine(result); 
        }
        static string GetSeason(int monthe)
        {
            string season;
            switch (monthe)
            {
                case 12:
                case 1:
                case 2:
                    season = "зима";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "весна";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "лето";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "осень";
                    break;
                default: return "sorry";
            }
            return season;
        }
        static int Deposit(int summ, int bet, int monthe)
        {
            int depositCalcul = (summ * bet / 100) + summ;
            while (monthe > 1)
            {
                depositCalcul += depositCalcul * bet / 100;
                monthe = monthe - 1;
            }
            return depositCalcul;
        }
        static bool IsAnagramm(string word1, string word2)
        {
            if (word1.Length == word2.Length)
            {
                word1.ToLower();
                word2.ToLower();
                int count = 0;
                int coun2 = 0;
                for (int i = 0; i < word1.Length; i++)
                {
                    if (word1[i] == word2[i++])
                    {
                        count++;
                    }
                }
                for (int i = 0; i < word2.Length; i++)
                {
                    if (word2[i] == word1[i++])
                    {
                        coun2++;
                    }

                }
                if (count == coun2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
