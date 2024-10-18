using System;

namespace University
{
    static class ArrayUtils
    {
        // Метод для пошуку кількості вказаних цифр у масиві
        public static int CountOccurrences(int[] array, int number)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item == number)
                {
                    count++;
                }
            }
            return count;
        }

        // Метод для пошуку максимального та мінімального елементів у масиві
        public static (int min, int max) FindMinMax(int[] array)
        {
            int min = array[0];
            int max = array[0];

            foreach (var item in array)
            {
                if (item < min) min = item;
                if (item > max) max = item;
            }

            return (min, max);
        }
    }
}
