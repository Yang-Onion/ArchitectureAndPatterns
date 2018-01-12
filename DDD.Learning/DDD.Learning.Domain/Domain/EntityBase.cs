using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.Domain
{
    public abstract class EntityBase<IdType>
    {
        private List<BusinessRule> _brokenRules = new List<BusinessRule>();
        public IdType Id { get; set; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object entity)
        {
            return  entity !=null 
                    &&entity is EntityBase<IdType>
                    && this == (EntityBase<IdType>)entity;
        }

        public static bool operator ==(EntityBase<IdType> entity1,EntityBase<IdType> entity2)
        {
            if (ReferenceEquals(entity1,null) && ReferenceEquals(entity2,null))
                return true;

            if (ReferenceEquals(entity1, null) || ReferenceEquals(entity2, null))
                return false;

            if (entity1.Id.ToString()== entity2.Id.ToString())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(EntityBase<IdType> entity1, EntityBase<IdType> entity2)
        {
            return !(entity1 == entity2);
        }

        public abstract void Validate();

        public void AddBrokenRules(BusinessRule businessRule)
        {
            _brokenRules.Add(businessRule);
        }

        public List<BusinessRule> GetBrokenRules()
        {
            _brokenRules.Clear();
            Validate();
            return _brokenRules;
        }
    }
}
