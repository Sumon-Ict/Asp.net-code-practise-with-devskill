using System;

namespace ECommerceSystem.Data
{
    public interface IEntity<T>
    {
        T id { get; set; }
    }
}
