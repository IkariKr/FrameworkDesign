using UnityEditor.Search;

namespace FrameworkDesign
{
    public interface IArchitecture
    {
        T GetUtility<T>() where T : class;
    }

    /// <summary>
    /// 创建IOC容器
    /// </summary>
    public abstract class Architecture<T> : IArchitecture where T : Architecture<T>, new() 
    {
        protected abstract void Init();

        private static T mArchitecture;

        static void MakeSureArchitecture()
        {
            if (mArchitecture == null)
            {
                mArchitecture = new T();
                mArchitecture.Init(); //为何这里可以用静态成员调用自己的方法？
            }
        }

        private IOCContainer mContainer = new IOCContainer();

        public static T Get<T>() where T : class
        {
            MakeSureArchitecture();
            return mArchitecture.mContainer.Get<T>();
        }

        public void Register<T>(T instance)
        {

        }

        public void RegisterUitility<T>(T instance)
        {
            MakeSureArchitecture();
            mArchitecture.mContainer.Register<T>(instance);
        }

        public void RegisterModel<T>(T model) where T : IBelongToArchitecture
        {
            model.Architecture = this;
            mArchitecture.mContainer.Register<T>(model);
        }

        public T GetUtility<T>() where T : class
        {
            return mContainer.Get<T>();
        }
    }
}