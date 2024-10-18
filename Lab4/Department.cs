namespace University
{
    public partial class Faculty
    {
        public partial class Department
        {
            public required string DepartmentName { get; set; }
            public int NumberOfTeachers { get; set; }

            public void SetDepartmentName(string name)
            {
                DepartmentName = name;
            }

            public void SetNumberOfTeachers(int number)
            {
                NumberOfTeachers = number;
            }
        }
    }
}
namespace University
{
    public partial class Faculty
    {
        public partial class Department
        {
            private string[] disciplines = new string[5];

            public string this[int index]
            {
                get { return disciplines[index]; }
                set { disciplines[index] = value; }
            }

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
    }
}
