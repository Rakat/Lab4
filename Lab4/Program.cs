using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4_1
{
    class Person
    {
        public string Name { get; set; } // ім'я
        public int Age { get; set; }   // вік
        public string Role { get; set; }  // роль
        public Person(string N, string R, int A)
        {
            Name = N;
            Age = A;
            Role = R;
        }
        public string GetName() { return Name; }
    }

    //class StudentAssesment part of Student
    class StudentAssesment
    {
        double[] assesment = new double[10]; // 10 дисциплін
        public double StRating(Random arand)
        {
            double rating = 0;
            for (int i = 0; i < 10; i++)
            {
                assesment[i] = arand.Next(56, 101); // випадкові числа від 56 до 100
                rating += assesment[i];
                Console.Write(assesment[i].ToString() + ",");
            }
            Console.WriteLine();
            return rating / 10; // середній рейтинг
        }
    }

    //class Student
    class Student : Person
    {
        public string Facultet { get; set; }
        public string Group { get; set; }
        public int Course { get; set; }
        public Student(string N, string R, int A, string F, string G, int C)
            : base(N, R, A)
        {
            //конструктор з параметрами 
            Name = N;
            Age = A;
            Role = R;
            Facultet = F;
            Group = G;
            Course = C;
        }

        // Створення екземпляра класу StudentAssesment
        StudentAssesment strating1 = new StudentAssesment();
        StudentAssesment strating2 = new StudentAssesment();

        public void MyRating(Random arand)
        {
            // Обчислення рейтингу за 2 модулі
            double Rating1 = strating1.StRating(arand);
            double Rating2 = strating2.StRating(arand);
            double Rating = (Rating1 + Rating2) / 2;

            Console.WriteLine("Рейтинг студента за семестр = " + Rating);

            // Виведення повідомлення на основі рейтингу
            if (Rating >= 82)
                Console.WriteLine("Привіт відмінникам");
            else if (Rating <= 60)
                Console.WriteLine("Перездача! Треба краще вчитися!");
            else
                Console.WriteLine("Можна вчитися ще краще!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створення екземпляра Student
            Student newSt = new Student("Іванов", "студент", 20, "КННІ", "K-01", 3);
            Random arand = new Random();
            newSt.MyRating(arand);

            Console.ReadKey();
        }
    }
}
