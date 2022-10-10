using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_library
{
    public interface ICustomStackReadOnly<out T> 
    {
        T Pop();
        //void Push(T value);
        int Count();
    }
}
