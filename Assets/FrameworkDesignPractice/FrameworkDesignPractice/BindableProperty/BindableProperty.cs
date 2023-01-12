using System;
using UnityEngine;

namespace FrameworkDesignPractice
{
    public class BindableProperty<T> where T : IEquatable<T>
    {
        private T mValue = default(T);
        
        public T Value
        {
            get => mValue;
            set
            {
                if (!mValue.Equals(value))
                {
                    mValue = value;
                }

                OnValueChangedEvent?.Invoke(value);
            }
        }

        public Action<T> OnValueChangedEvent;
    }
}