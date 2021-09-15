using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<K,V>
    {

        K[] _key;
        V[] _value;

        K[] _tempKey;
        V[] _tempValue;
        public MyDictionary()
        {
            _key = new K[0];
            _value = new V[0];
        }
        public void Add(K key, V value)
        {
            _tempKey = _key;
            _tempValue = _value;

            _key = new K[_key.Length + 1];
            _value = new V[_value.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _tempKey[i] = _key[i];
                _tempValue[i] = _value[i];
            }
            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }

        public V Get(K key)
        {
            for (int i = 0; i < _key.Length; i++)
            {
                if (_key[i].Equals(key))
                {
                    return _value[i];
                }
            }
            return _value[_value.Length + 1];
        }


    }
}
