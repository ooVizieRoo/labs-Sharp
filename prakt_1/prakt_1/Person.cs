using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_1
{
    class Person
    {
        private string Name;
        private string Family;
        private DateTime BirthDate;
        #region Конструкторы
        //Конструктор по умолчанию
        public Person()
        {
            Name = "Noname";
            Family = "Nofamily";
            BirthDate = new DateTime(1995,1,1);
        }

        //Конструктор с параметрами
        public Person(string Name, string Family, DateTime BirthDate)
        {
            this.Name = Name;
            this.Family = Family;
            this.BirthDate = BirthDate;
        }
        #endregion

        #region get set
        public string AccessName
        {
            set
            {
                Name = value;
            }
            get
            {
                return Name;
            }
        }

        public string AccessFamily
        {
            set
            {
                Family = value;
            }
            get
            {
                return Family;
            }
        }

        public DateTime AccessDate
        {
            set
            {
                BirthDate = value;
            }
            get
            {
                return BirthDate;
            }
        }

        public int ChangeYear
        {
            set
            {
                int Day = BirthDate.Day;
                int Month = BirthDate.Month;
                BirthDate = new DateTime(value, Month, Day);
            }
            get
            {
                return BirthDate.Year;
            }
        }
#endregion

        public override string ToString()
        {
            return "Имя: " + Name.ToString() + "; Фамилия: " + Family.ToString() + "; Дата Рождения: " + BirthDate.ToString();
        }

        public virtual string ToShortString()
        {
            return "Имя: " + Name.ToString() + "; Фамилия: " + Family.ToString();
        }
    }
}
