using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace prakt_1
{
    class Student : Person, IDateAndCopy
    {
        private Education edu;
        private int groupNumber;
        private ArrayList passedTest;
        private Exam[] passedEx;

        #region Свойства
        Person person
        {
            get 
            { 
                return person; 
            }
            set
            {
                person = value;
                this.Name = value.AccessName;
                this.Family = value.AccessFamily;
                this.Date = value.Date;
            }
        }
        ArrayList accessTest
        {
            get
            {
                return passedTest;
            }
            set
            {
                
                passedTest = value;
            }
        }
        Exam[] accessExam
        {
            get
            {
                return passedEx;
            }
            set
            {
                passedEx = new Exam[value.Length];
                passedEx = value;
            }
        }
        double averageMark
        {
            get
            {
                int sum = 0;
                foreach (Exam exam in passedEx)
                {
                    sum += exam.Mark;
                }

                return sum / passedEx.Length;
            }
        }
        int accessGN
        {
            get
            {
                return groupNumber;
            }
            set
            {
                string textError = "Ошибка: номер группы должен находиться в диапозоне от 101 до 599";
                try
                {
                    if ((value <= 100) || (value > 599))
                        throw new Exception(textError);

                    groupNumber = value;
                }
                catch (Exception)
                {
                    Console.WriteLine();
                }
            }
        }
        #endregion

        #region Конструкторы
        public Student()
            : base()
        {
            edu = Education.Bachelor;
            groupNumber = 318;
        }

        public Student(Person p, Education edu, int groupNumber)
        {
            this.edu = edu;
            this.groupNumber = groupNumber;
            base.Name = p.AccessName;
            base.Family = p.AccessFamily;
            base.BirthDate = p.Date;
        }
        #endregion

        public void AddExams(params Exam[] aaa)
        {
            accessExam = aaa;
        }

        public void AddTests(params Test[] aaa)
        {
            foreach (Test ob in aaa)
                passedTest.Add(ob);
        }

        public override string ToString()
        {
            string str = "Квалификация: " + edu + "; Номер группы: " + groupNumber +"; ||| ";
            str += "Список cданных зачетов: ";

            foreach (Test ob in passedTest)
                str += ob.ToString();

            str += "||| Список сданных экзаменов: ";

            foreach (Exam ex in passedEx)
                str += ex.ToString();

            return base.ToString() + str;
        }

        public override string ToShortString()
        {
            string str = "Квалификация: " + edu + "; Номер группы: " + groupNumber + "; ||| ";

            return base.ToShortString() + str + "Средний балл: " + averageMark.ToString();
        }

        public override object DeepCopy()
        {
            Student copy = new Student();

            copy = (Student)base.DeepCopy();
            copy.edu = this.edu;
            copy.groupNumber = this.groupNumber;
            copy.passedTest = this.accessTest;
            copy.passedEx = this.accessExam;
            return copy;
        }
    }
}
