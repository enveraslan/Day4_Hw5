using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_Hw5
{
    
    class MyDictionary<K, V>
    {
        DictionaryItem<K, V>[] items;

        public MyDictionary()
        {
            items = new DictionaryItem<K, V>[0];
        }

        public void Add(K key, V value)
        {
            DictionaryItem<K, V>[] tempDictionary = items;
            items = new DictionaryItem<K, V>[items.Length + 1];
            for (int i = 0; i < tempDictionary.Length; i++)
            {
                items[i] = tempDictionary[i];
            }
            items[items.Length - 1] = new DictionaryItem<K, V> { Key = key,Value = value };
        }

        public int Length { get { return items.Length; } }
    }
}
