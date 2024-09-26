using System;

namespace Humidifier.Helpers
{
    public class WithFallback<T>
    {
        private T _value;
        private bool _valueIsSet;
        public Func<T> ValueFactory { get; set; }

        public WithFallback()
        {
        }

        public WithFallback(T value)
        {
            Value = value;
            _valueIsSet = true;
        }

        public WithFallback(Func<T> valueFactory)
        {
            ValueFactory = valueFactory;
        }

        public T Value
        {
            get
            {
                if (_valueIsSet)
                {
                    return _value;
                }

                var value = ValueFactory();
                return value;
            }
            set
            {
                _valueIsSet = true;
                _value = value;
            }
        }

        public static implicit operator T(WithFallback<T> withFallback)
        {
            return withFallback.Value;
        }
    }
}