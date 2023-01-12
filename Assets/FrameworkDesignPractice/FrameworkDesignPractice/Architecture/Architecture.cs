using UnityEngine;

namespace FrameworkDesignPractice
{
    /// <summary>
    /// 创建IOC容器
    /// </summary>
    public abstract class Architecture<T> where T:Architecture<T>, new()
    {
        protected abstract void Init();
        
        private static T mInstance;
        
        
        static void MakeSureArchitecture()
        {
            if (mInstance == null)
            {
                mInstance = new T();
                mInstance.Init();
            }
        }
        
        private IOCContainer mContainer = new IOCContainer();
        
        public static T1 Get<T1>() where T1 : class
        {
            MakeSureArchitecture();
            return mInstance.mContainer.Get<T1>();
        }

        public void Register<T2>(T2 instance)
        {
            MakeSureArchitecture();
            mInstance.mContainer.Register<T2>(instance);
        }
        
    }
}