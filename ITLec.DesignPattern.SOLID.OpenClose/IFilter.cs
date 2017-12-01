using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.SOLID.OpenClose
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ICriteria<T> criteria);
    }
}
