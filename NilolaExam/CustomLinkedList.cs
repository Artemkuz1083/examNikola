using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilolaExam
{
    public class CustomLinkedList<T>
    {
        private Node<T> first { get; set; }
        private Node<T> last { get; set; }
        private int count;

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public T First { get { return first.Data; } }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (first == null)
            {
                first = node;
            }
            else
            {
                last.Next = node;
            }

            last = node;
            count++;
        }

        public void AddFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = first;
            first = node;
            if(count == 0)
            {
                last = first;
            }

            count++;
        }


        public void RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Linked list is empty");
            }
            first = first.Next;
            if(first == null)
            {
                last = null;
            }
            count--;
        }
    }
}
