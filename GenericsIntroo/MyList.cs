﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntroo
{
    class MyList <T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < length; i++)
            {
                items[i] = tempArray[i];

            }
            items[items.Length - 1] = item;
        }     
    }
}
