using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.SOLID.OpenClose
{
    public class BirthdayCriteria : ICriteria<Employee>
    {
        DateTime birthday;
        public BirthdayCriteria(DateTime birthday)
        {
            this.birthday = birthday;
        }
        public bool IsAccepted(Employee t)
        {
          return  t.Birthday > this.birthday;
        }
    }
}
