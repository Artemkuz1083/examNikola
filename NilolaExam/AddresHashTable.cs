using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilolaExam
{
    public class AddresHashTable<String, V>    {
        private int _size;
        private (string key, V val)[] _table;


        public AddresHashTable(int size)
        {
            _size = size;
            _table = new (string key, V)[size];
        }

        private int LinerProbing(string key, int attempt)
        {
            return (Convert.ToInt32(key).GetHashCode() + attempt) % _size;
        }

        public void Insert(int key, V val)
        {
            int i = 0;
            string parseKey = Convert.ToString(key);
            while (i < _size)
            {
                int index = LinerProbing(parseKey, i);
                if (_table[index].key == null)
                {
                    _table[index] = (parseKey, val);
                    return;
                }
                i++;
            }
            throw new Exception("HashTable overflow");
        }

        public void Print()
        {
            for(int i = 0; i < _table.Length; i++)
            {
                Console.Write($"{i}: ");
                if(_table[i].key != null)
                    Console.Write($"({_table[i].key}, {_table[i].val})\n");
                else
                    Console.Write("null \n");
                
            }
        }
    }

}