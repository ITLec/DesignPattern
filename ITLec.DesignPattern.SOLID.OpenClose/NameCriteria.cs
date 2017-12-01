using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.SOLID.OpenClose
{
    public class NameCriteria : ICriteria<Employee>
    {
        private string name;
        public NameCriteria(string name)
        {
            this.name = name;
        }
        public bool IsAccepted(Employee t)
        {
            return t.FullName.ToLower().Contains(name.ToLower());
        }

    }
}
