using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<K , V>
    {
        K[] key;
        V[] value;

        public MyDictionary()
        {
            key = new K[0];
            value = new V[0];

        }
        public void Add(K keys , V values)
        {
            K[] tempKey = key;
            key = new K[key.Length + 1];
            for (int i = 0; i <tempKey.Length; i++)
            {
                key[i] = tempKey[i];
            }

            key [key.Length - 1] = keys;


            V[] tempValue = value;
            value = new V[value.Length + 1];
            for (int j = 0; j < tempValue.Length ;j++)
            {
                value[0] = tempValue[0];
            }
            value [value.Length - 1] = values;
        }
        public int Count
        {
            get { return key.Length; } 
        }
        public K[] _keys
        {
            get { return key; }
        }
        public V[] _value
        {
            get { return value; }
        }
    }
}
