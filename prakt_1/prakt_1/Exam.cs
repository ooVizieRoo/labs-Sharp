using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_1
{
    class Exam : IDateAndCopy
    {
        #region Свойства
        public string ItemName
        {
            get;
            set;
        }

        public int Mark
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }


        #endregion

        #region Конструкторы
        //По умолчанию
        public Exam()
        {
            this.ItemName = "NoItemName";
            this.Mark = 0;
            this.Date = new DateTime(2016, 06, 1);
        }

        //С параметрами
        public Exam(string ItemName, int Mark, DateTime DateExam)
        {
            this.ItemName = ItemName;
            this.Mark = Mark;
            this.Date = DateExam;
        }
        #endregion

        public override string ToString()
        {
            return ItemName + "; " + Mark + "; " + Date + "; ";
        }

        public virtual object DeepCopy()
        {
            Exam ex = new Exam(this.ItemName, this.Mark, this.Date);
            return ex;
        }
    }
}
