using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            Console.WriteLine(stu1.ToShortString());
            Console.WriteLine();

            stu1.person = new Person("Иван", "Иванов", new DateTime(1995, 06, 23));
            stu1.accessGN = 105;
            Console.WriteLine(stu1.ToString());
            Console.WriteLine();

            Exam[] listEx = new Exam[2];
            listEx[0] = new Exam("МАТАН", 5, DateTime.Now);
            listEx[1] = new Exam("ООП", 5, DateTime.Today);
            stu1.AddExams(listEx);
            Console.WriteLine(stu1.ToString());
            Console.WriteLine();

            Person p1 = new Person();
            Person p2 = new Person();

            Console.WriteLine("Хеш-код 1: " + p1.GetHashCode());
            Console.WriteLine("Хеш-код 2: " + p2.GetHashCode());
            Console.WriteLine();

            Student stud2 = new Student(new Person("Петр", "Петров", new DateTime(1995, 12, 12)), Education.Specialist, 222);

            stud2.AddExams(listEx);
            Test[] listTest = new Test[3];
            listTest[0] = new Test("ИГ ПР", true, DateTime.Now);
            listTest[1] = new Test("Социология", false, DateTime.Now);
            listTest[2] = new Test("Электротехника", true, DateTime.Now);

            stud2.AddTests(listTest);
            Console.WriteLine(stud2.ToString());
            Console.WriteLine();

            string str = stud2.person.ToString();
            Console.WriteLine("Значение свойства типа Student: ");
            Console.WriteLine(str);

            Student stud2Copy = new Student();
            stud2Copy = (Student)stud2.DeepCopy();

            stud2Copy.AccessName = "Сидор";
            stud2Copy.accessGN = 333;
            Console.WriteLine(stud2.ToString());
            Console.WriteLine();
            Console.WriteLine(stud2Copy.ToString());
            Console.WriteLine();

            stud2Copy.accessGN = 777;
            Console.WriteLine();

            foreach (Exam ex in stud2Copy.accessExam)
                Console.WriteLine(ex.ItemName);
            Console.WriteLine();


            foreach (Exam ex in stud2Copy.accessExam)
                if (ex.Mark > 3)
                    Console.WriteLine(ex.ItemName);

            Console.ReadKey();
        }
    }
}
