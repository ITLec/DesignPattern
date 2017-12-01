using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.SOLID.OpenClose
{
    public interface ICriteria<T>
    {
        bool IsAccepted(T t);
    }
}
