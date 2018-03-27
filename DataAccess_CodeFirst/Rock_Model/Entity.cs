using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rock_Model
{
    public abstract class BaseEntity
    {

    }

    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        public virtual T ID { get; set; }
    }

    public interface IEntity<T>
    {
        T ID { get; set; }
    }
}
