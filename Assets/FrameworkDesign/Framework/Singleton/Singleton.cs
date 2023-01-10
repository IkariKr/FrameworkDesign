using System;
using System.Reflection;
using UnityEngine;

namespace FrameworkDesign
{
    /// <summary>
    /// 实现单例
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Singleton<T> where T : Singleton<T>
    {
        private static T mInstance;

        public static T Instance
        {
            get
            {
                if (mInstance == null)
                {
                    var type = typeof(T);
                    //获取构造函数
                    var ctors = type.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);
                    //获取无参构造
                    var ctor = Array.Find(ctors, c => c.GetParameters().Length == 0);
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