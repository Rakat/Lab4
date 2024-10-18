using System;

namespace University
{
    // Class Faculty
    public class Faculty
    {
        public required string FacultyName { get; set; }

        // Вкладений клас Department (Кафедра)
        public class Department
        {
            public required string DepartmentName { get; set; }
            public int NumberOfTeachers { get; set; }
            private string[] disciplines = new string[5]; // Ініціалізація дисциплін

            // Метод для встановлення назви кафедри
            public void SetDepartmentName(string name)
            {
                DepartmentName = name;
            }

            // Метод для введення кількості викладачів кафедри
            public void SetNumberOfTeachers(int number)
            {
                NumberOfTeachers = number;
            }

            // Індексатор для дисциплін кафедри
            public string this[int index]
            {
                get { return disciplines[index]; }
                set { disciplines[index] = value; }
            }

            // Метод для виведення інформації про кафедру
            public void ShowDepartmentInfo()
            {
                Console.WriteLine($"Кафедра: {DepartmentName}, Викладачі: {NumberOfTeachers}");
                Console.WriteLine("Дисципліни кафедри:");
                foreach (var discipline in disciplines)
                {
                    Console.WriteLine(discipline);
                }
            }
        }

        // Створення двох екземплярів класу Department
        Department department1 = new Department();
        Department department2 = new Department();

        // Метод для виклику методів класу Department
        public void InitializeDepartments()
        {
            department1.SetDepartmentName("Комп'ютерні науки");
            department1.SetNumberOfTeachers(10);
            department1[0] = "Програмування";
            department1[1] = "Алгоритми";
            department1[2] = "Математика";
            department1[3] = "Мережі";
            department1[4] = "Інженерія ПЗ";

            department2.SetDepartmentName("Вища математика");
            department2.SetNumberOfTeachers(5);
            department2[0] = "Математичний аналіз";
            department2[1] = "Лінійна алгебра";
            department2[2] = "Дискретна математика";
            department2[3] = "Теорія ймовірностей";
            department2[4] = "Статистика";

            // Виведення інформації
            Console.WriteLine($"Факультет: {FacultyName}");
            department1.ShowDepartmentInfo();
            department2.ShowDepartmentInfo();
        }
    }
}
