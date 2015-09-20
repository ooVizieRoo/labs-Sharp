using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace prakt_1
{
    class Student : Person
    {
        private Education Edu;
        private int GroupNumber;
        private ArrayList Exempoints;
        private Exam[] passedEx;

        #region Конструкторы
        public Student(): base()
        {
            Edu = Education.Bachelor;
            GroupNumber = 318;
        }

        public Student(Person p, Education Edu, int GroupNumber)
        {
            this.Edu = Edu;
            this.GroupNumber = GroupNumber;
            base.Name = p.AccessName;
            base.Family = p.AccessFamily;
            base.BirthDate = p.Date;
        }
        #endregion
    }
}
