using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_1
{
    class Test : IDateAndCopy
    {
        #region Свойства
        public string ItemName
        {
            get;
            set;
        }

        public bool Passed
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
        public Test()
        {
            ItemName = "NoItemName";
            Passed = false;
        }

        public Test(string ItemName, bool Passed, DateTime Date)
        {
            this.ItemName = ItemName;
            this.Passed = Passed;
            this.Date = Date;
        }
        #endregion

        public override string ToString()
        {
            return ItemName.ToString() + "; " + Passed.ToString() + "; " + Date.ToString() + "; ";
        }
        public virtual object DeepCopy()
        {
            Test t = new Test(ItemName, Passed, Date);
            return t;
        }
    }
}
