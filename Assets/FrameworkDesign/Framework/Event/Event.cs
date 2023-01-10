using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameworkDesign
{
    public class Event<T> where T : Event<T>
    {
        private static Action mOnAction;

        public static void Register(Action onAction)
        {
            mOnAction += onAction;
        }

        public static void UnRegister(Action onAction)
        {
            mOnAction -= onAction;
        }

        public static void Trigger()
        {
            mOnAction?.Invoke();
        }
        
    }
}