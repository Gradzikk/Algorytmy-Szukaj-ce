using System;

namespace LinearSearchExample
{
    class Program
    {
        static void Main(string[] args)
        {
 
            int[] array = new int[100];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }

            int searchValue = 50;

            int linearSearchResult = LinearSearch(array, searchValue);
            Console.WriteLine($"Wynik wyszukiwania liniowego: {linearSearchResult}");

            int sentinelSearchResult = SentinelLinearSearch(array, searchValue);
            Console.WriteLine($"Wynik wyszukiwania liniowego z wartownikiem: {sentinelSearchResult}");
        }


        static int LinearSearch(int[] array, int searchValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchValue)
                {
                    return i;
                }
            }
            return -1;
        }

        static int SentinelLinearSearch(int[] array, int searchValue)
        {
   
            array[array.Length - 1] = searchValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchValue)
                {
                   
                    if (i == array.Length - 1)
                    {
                        return -1;
                    }
                    else
                    {
                        return i; 
                    }
                }
            }
            return -1;
        }
    }
}
