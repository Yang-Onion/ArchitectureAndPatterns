using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace RepositoryPattern.Domain
{
    public abstract class Entity<TPrimaryKey>:IEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }

        public override bool Equals(object obj)
        {
            if (obj==null || !(obj is Entity<TPrimaryKey>))
            {
                return false;
            }
            if (ReferenceEquals(this,obj))
            {
                return true;
            }

            var other = (Entity<TPrimaryKey>)obj;
            var typeOfThis = this.GetType();
            var typeOfOther = other.GetType();
            if (!typeOfThis.GetTypeInfo().IsAssignableFrom(typeOfOther) && !typeOfOther.GetTypeInfo().IsAssignableFrom(typeOfThis))
            {
                return false;
            }
            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public static bool operator ==(Entity<TPrimaryKey> left,Entity<TPrimaryKey> right)
        {
            if (Equals(left,null))
            {
                return Equals(right, null);
            }
            return left.Equals(right);
        }

        public static bool operator !=(Entity<TPrimaryKey> left, Entity<TPrimaryKey> right)
        {
            return !(left == right);
        }
    }

    public abstract class Entity : Entity<string>, IEntity
    {

    }
}
