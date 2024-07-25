﻿namespace AdrilBank.Domain.Base.Models
{
    public abstract class ValueObject<T> where T : ValueObject<T>
    {
        public override bool Equals(object obj) => obj is T valueObject && EqualsCore(valueObject);
        public override int GetHashCode() => GetHashCodeCore();

        protected abstract int GetHashCodeCore();
        protected abstract bool EqualsCore(T other);

        public static bool operator ==(ValueObject<T> a, ValueObject<T> b)
        {
            if (a is null && b is null) return true;

            if (a is null || b is null) return false;

            return a.Equals(b);
        }

        public static bool operator !=(ValueObject<T> a, ValueObject<T> b) => !(a == b);
    }
}
