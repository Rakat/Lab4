namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            // Тестування класу Faculty
            Faculty faculty = new Faculty();
            faculty.FacultyName = "Комп'ютерних наук та кібернетики";
            faculty.InitializeDepartments();

            // Тестування статичного класу ArrayUtils
            int[] numbers1 = { 1, 2, 5, 3, 7, 5, 1, 3, 4 };
            int[] numbers2 = { 4, 5, 2, 3, 8, 7, 6, 1 };

            // Лінійний пошук кількості цифр
            int count = ArrayUtils.CountOccurrences(numbers1, 5);
            Console.WriteLine($"Кількість цифр 5 у масиві: {count}");

            // Пошук мінімального і максимального елементів
            var (min, max) = ArrayUtils.FindMinMax(numbers2);
            Console.WriteLine($"Мінімальний елемент: {min}, Максимальний елемент: {max}");

            Console.ReadKey();
        }
    }
}
