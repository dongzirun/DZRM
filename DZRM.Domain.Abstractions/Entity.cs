﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DZRM.Domain.Abstractions
{
    public abstract class Entity : IEntity
    {
        public abstract object[] GetKeys();

        public override string ToString()
        {
            return $"[Entity: {GetType().Name}] Keys = {string.Join(",", GetKeys())}";
        }

    }

    public abstract class Entity<TKey> : Entity, IEntity<TKey>
    {
        int? _requestedHashCode;
        public virtual TKey Id { get; protected set; }

        public override object[] GetKeys()
        {
            return new object[] { Id };
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Entity<TKey>))
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            if (this.GetType() != obj.GetType())
                return false;

            Entity<TKey> item = (Entity<TKey>)obj;

            if (item.IsTransient() || this.IsTransient())
                return true;
            else
                return item.Id.Equals(this.Id);
        }

        //表示对象是否为全新创建的，未持久化的
        private bool IsTransient()
        {
            return EqualityComparer<TKey>.Default.Equals(Id, default);
        }

        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                if (!_requestedHashCode.HasValue)
                    _requestedHashCode = this.Id.GetHashCode() ^ 31;

                return _requestedHashCode.Value;
            }
            else
                return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"[Entity: {GetType().Name}] Id = {Id}";
        }


        public static bool operator ==(Entity<TKey> left, Entity<TKey> right)
        {
            if (Object.Equals(left, null))
                return (Object.Equals(right, null)) ? true : false;
            else
                return left.Equals(right);
        }

        public static bool operator !=(Entity<TKey> left, Entity<TKey> right)
        {
            return !(left == right);
        }
    }
}
