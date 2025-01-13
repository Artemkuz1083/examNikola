using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilolaExam
{
    public class CustomStack<T>
    {
        new CustomLinkedList<T> stack = new CustomLinkedList<T>();

        public int Count { get { return stack.Count; } }
        public bool IsEmpty { get {return stack.IsEmpty;} }

        public void Push(T item)
        {
            stack.AddFirst(item);
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new Exception("stack is empty");
            T res = stack.First;
            stack.RemoveFirst();
            return res;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new Exception("stack is empty");
            return stack.First;
        }
    }
}
