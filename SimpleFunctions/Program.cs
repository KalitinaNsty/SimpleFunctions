using System;

namespace SimpleFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = GetRandom(5, 0, 10);
            Write(randomArray);
            double toFaringate = ToFaringate(36.6);
            Console.WriteLine("Введите слово для проверки на палиндром: ");
            string word = Console.ReadLine();
            bool isPalindrom = IsPalindrom(word);
            int summElement = GetSummElement(randomArray);
            Console.WriteLine(summElement);
            Console.WriteLine("введите число: ");
            int digit = int.Parse(Console.ReadLine());
            int countDigit = CountDigit(digit);
            Console.WriteLine($"количество чисел в числе = {countDigit}");
            string address = GetAddress("Тольятти", "Революционная", 30, 132);
            Console.WriteLine(address);
            bool isEven = IsEven(digit);
            Console.WriteLine(isEven);
            int factorial = Factorial(5);
            Console.WriteLine($"факториал 5 = {factorial}");
            Console.WriteLine("Введите символ: ");
            char symbol = Console.ReadKey().KeyChar;
            int countContains = GetCountContains(word, symbol);
            Console.WriteLine($"этот символ встречается в слове {countContains} раз");
            int a = 15;
            int b = 3;
            Console.WriteLine($"{a}, {b}");
            SwapDigit(ref a, ref b);
            Console.WriteLine($"число после функции swap: {a}, {b}");
            Console.WriteLine("Введите слово: ");
            string word1 = Console.ReadLine();
            Console.WriteLine("ВВедите слово: ");
            string word2 = Console.ReadLine();
            SwapSting(ref word1, ref word2);
            Console.WriteLine($"слова после фукции swap: {word1}, {word2}");
            Console.WriteLine("введите символ 1: ");
            char simbol1 = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("введите символ 2: ");
            char simbol2 = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine($"символы после функции swap: {simbol1}, {simbol2}");
        }
        static int[] GetRandom(int size, int min, int max)
        {
            Random rnd = new Random();
            int[] rndArray = new int[size];
            for (int i = 0; i < rndArray.Length; i++)
            {
                rndArray[i] = rnd.Next(min, max);
            }
            return rndArray;
        }
        static void Write(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
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
