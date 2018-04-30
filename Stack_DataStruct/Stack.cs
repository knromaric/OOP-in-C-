using System;
using System.Collections.Generic;

namespace Stack_DataStruct
{
    public class Stack
    {
        private readonly List<object> _myStack;

        public Stack()
        {
            _myStack = new List<Object>();
        }
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Null value cannot be stored in the stack");
            _myStack.Add(obj);
        }

        public object Pop()
        {
            if (_myStack.Count == 0)
                throw new InvalidOperationException("Cannot retrieve object from empty stack");
            object temp= _myStack[_myStack.Count - 1];
            _myStack.RemoveAt(_myStack.Count - 1);
            return temp;

        }

        public void Clear()
        {
            _myStack.Clear();
        }
    }
}
