using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tvalue,Tkey>
    {
        Tvalue[] tvalues;
        Tkey[] tkeys;

        public MyDictionary()
        {
            tvalues = new Tvalue [0] ;
            tkeys = new Tkey[0];
        }
        public void Add(Tvalue value, Tkey key)
        {
            Tvalue[] tempVal = tvalues;
            Tkey[] tempKey = tkeys;
            tvalues = new Tvalue[tvalues.Length + 1];
            tkeys = new Tkey[tkeys.Length + 1];
            for (int i = 0; i < tempVal.Length; i++)
            {
                tvalues[i] = tempVal[i];
                tkeys[i] = tempKey[i];
            }
            tvalues[tvalues.Length - 1] = value;
            tkeys[tkeys.Length - 1] = key;
        }
        public int Lenght
        {
            get { return tkeys.Length; }
        }
        public Tkey[] Keys
        {
            get { return tkeys; }
        }
        public Tvalue[] Values
        {
            get { return tvalues; }
        } 
    }
}
