using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.SOLID.OpenClose
{
    public class AndCriteria<T> : ICriteria<T>
    {
        private ICriteria<T> first, second;

        public AndCriteria(ICriteria<T> first, ICriteria<T> second)
        {
            this.first = first;
            this.second = second;
        }

        public bool IsAccepted(T t)
        {
            return first.IsAccepted(t) && second.IsAccepted(t);
        }
    }
}
