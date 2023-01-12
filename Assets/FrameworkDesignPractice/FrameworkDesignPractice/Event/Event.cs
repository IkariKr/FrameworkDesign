using System;
using UnityEngine;

namespace FrameworkDesignPractice
{
    public class Event<T> where T : Event<T> //添加泛型参数可以让每种类共享一个静态成员，并在不同类之间区分。
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