using System;
namespace Nullables
{
    public struct Nullable<T> where T : struct
    {
        private readonly T _value;
        private readonly bool _hasValue;

        public Nullable(T value)
        {
            _value = value;
            _hasValue = true;
        }

        public bool HasValue { get { return _hasValue; } }

        public T Value
        {
            get
            {
                if (!_hasValue)
                {
                    throw new InvalidOperationException();
                }

                return _value;
            }
        }
    }
}
