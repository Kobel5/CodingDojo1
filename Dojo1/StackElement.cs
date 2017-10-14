using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo1
{
    class StackElement<T>
    {
        public T value { get; set; } //Stores the value of the staack entry
        public StackElement<T> nextElement { get; set; }
    }
}
