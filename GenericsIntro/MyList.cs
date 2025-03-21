﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //CONSTRUCTOR
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempaArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempaArray.Length; i++)
            {
                items[i] = tempaArray[i];
            }
            items[items.Length - 1] = item;
        }
        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
