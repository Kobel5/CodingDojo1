using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo1
{
    class Stack<T>
    {
        public StackElement<T> first;

        public T Peek()
        {
            if (first != null)
            {
                return first.value;
            }
            else
            {
                return default(T);
            }
        }

        public void Push(T element)
        {
            if (first != null)
            {
                StackElement<T> temp = new StackElement<T>() {value = element, nextElement=first };
                first = temp;
            }
            else
            {
                first = new StackElement<T>()
                {
                    value = element,
                    nextElement = null
                };
            }
        }

        public T Pop()
        {
            if (first != null)
            {
                T temp = first.value;
                first = first.nextElement;
                return temp;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
