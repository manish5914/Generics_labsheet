using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_library
{
    public interface ICustomStack<T>: ICustomStackReadOnly<T>
    {
       
        void Push(T value);
       
    }
    //push will break cuz push cannot take in value 
    // solution break interface into 2 with one being for "out T" for read only 
    // then base interface will implement the readonly interface 
    // and base interface can take in T value;
}
