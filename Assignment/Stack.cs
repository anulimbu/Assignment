﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
public class Stack<T>
    {
        private List<T> items;

        public Stack()
        {
            items = new List<T>();
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            return items[items.Count - 1];
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }
    }
}