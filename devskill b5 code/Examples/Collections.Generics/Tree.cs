using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Examples.Collections.Generics
{
    public class Tree<T>
    {
        public readonly string key = "default";
        public T Current { get; set; }
        public List<Tree<T>> Children { get; set; }

        public Tree()
        {
            key = "something";
            Children = new List<Tree<T>>();
        }

        public Tree(T current) : this()
        {
            Current = current;
        }

        public int GetValue<X>(X something, T vehicle)
        {
            return 5;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
