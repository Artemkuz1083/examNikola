using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilolaExam
{
    public class CustomQueue<T>
    {

        private Node<T>? head;
        private Node<T>? tail;

        public bool IsEmpty { get { return queue.IsEmpty; } }

        new CustomLinkedList<T> queue = new CustomLinkedList<T>();

        public void Enqueue(T item)
        {
            queue.Add(item);
        }

        public T Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("queue is empty");
            }
            var res = queue.First;
            queue.RemoveFirst();

            return res;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("queue is empty");
            }
            var res = queue.First;

            return res;
        }
    }
}
