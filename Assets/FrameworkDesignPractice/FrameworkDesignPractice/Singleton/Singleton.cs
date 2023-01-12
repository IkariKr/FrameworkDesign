using System;
using System.Reflection;
using UnityEngine;

namespace FrameworkDesignPractice
{
    public class Singleton<T> where T:Singleton<T>
    {
        private static T mInstance;

        public static T instance
        {
            get
            {
                if (mInstance == null)
                {
                    var type = typeof(T);
                    var ctors = type.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);
                    var ctor= Array.Find(ctors, c => c.GetParameters().Length == 0);
                    if (ctor == null)
                    {
                        throw new Exception("Non Public Constructor Not Found" + type.Name);
                    }

                    mInstance = ctor.Invoke(null) as T;
                }

                return mInstance;
            }
        }

    }
}