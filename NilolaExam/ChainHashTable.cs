using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilolaExam
{
    public class ChainHashTable<K,V>
    {
        private int _size;
        private LinkedList<KeyValuePair<K, V>>[] _table;

        public ChainHashTable(int size)
        {
            _size = size;
            _table = new LinkedList<KeyValuePair<K, V>>[size];

            for (int i = 0; i < size; i++)
            {
                _table[i] = new LinkedList<KeyValuePair<K, V>>();
            }
        }

        public int GetIndex(K key)
        {
            return key.GetHashCode() % _size;
        }

        public void Insert(K key, V value)
        {
            int index = GetIndex(key);
            _table[index].AddFirst(new KeyValuePair<K, V>(key, value));
        }

        public void Print()
        {
            for (int i = 0; i < _table.Length; i++)
            {
                Console.Write($"[ {i}: ");
                if (_table[i] != null && _table[i].Count > 0)
                {
                    foreach (var kvp in _table[i])
                    {
                        Console.Write($"({kvp.Key}: {kvp.Value}) -> ");
                    }
                    Console.WriteLine("null ]");
                }
                else
                {
                    Console.WriteLine("... ]");
                }
            }
        }

    }
}
