using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.SOLID.OpenClose
{
    public class EmployeeFilter : IFilter<Employee>
    {
        public IEnumerable<Employee> Filter(IEnumerable<Employee> items, ICriteria<Employee> criteria)
        {
            foreach (var i in items)
                if (criteria.IsAccepted(i))
                    yield return i;
        }
    }
}
