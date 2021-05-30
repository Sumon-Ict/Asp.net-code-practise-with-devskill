using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Box<T>
    {
        public T Width { get; set; }
        public T Height { get; set; }
        public T Length { get; set; }
    }
}
