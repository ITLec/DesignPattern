using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.SOLID.OpenClose
{
    public class GenderCriteria : ICriteria<Employee>
    {
        private Gender gender;

        public GenderCriteria(Gender gender)
        {
            this.gender = gender;
        }
        public bool IsAccepted(Employee t)
        {
            return t.Gender == this.gender;
        }
    }
}
