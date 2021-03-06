﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_1
{
    interface IDateAndCopy
    {
        object DeepCopy();
        DateTime Date { get; set; }
    }
    
    enum Education
    {
        Specialist = 0,
        Bachelor,
        SecondEducation
    }

    class Person : IDateAndCopy
    {
        protected string Name;
        protected string Family;
        protected DateTime BirthDate;
        #region Конструкторы
        //Конструктор по умолчанию
        public Person()
        {
            Name = "Noname";
            Family = "Nofamily";
            BirthDate = new DateTime(1995, 1, 1);
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

        public DateTime Date
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

        #region Вывод  значений полей класса
        //Всех
        public override string ToString()
        {
            return "Имя: " + AccessName.ToString() + "; Фамилия: " + AccessFamily.ToString() + "; Дата Рождения: " + Date.ToString();
        }

        //Только имя и фамилия
        public virtual string ToShortString()
        {
            return "Имя: " + Name.ToString() + "; Фамилия: " + Family.ToString();
        }
        #endregion

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Person p = obj as Person;
            if (p == null)
                return false;


            return (p.Name == this.Name) && (p.Family == this.Family) && (p.BirthDate == this.BirthDate);
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !p1.Equals(p2);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public virtual object DeepCopy()
        {
            Person copy = new Person();

            copy.Name = this.Name;
            copy.Family = this.Family;
            copy.BirthDate = this.BirthDate;

            return copy;
        }
    }
}
