using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameworkDesign
{
    public class BindableProperty<T> where T : IEquatable<T> //可比较的
    {
        private T mValue = default(T);

        public T Value
        {
            get
            {
                return mValue;
            }
            set
            {
                if (!mValue.Equals(value))
                {
                    mValue = value;
                    OnValueChanged?.Invoke(value);
                }
                
            }
        }

        public Action<T> OnValueChanged;

    }
}