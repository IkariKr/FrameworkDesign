using FrameworkDesign;
using UnityEngine;

namespace CounterApp
{
    public class CounterApp : Architecture<CounterApp>
    {
        protected override void Init()
        {
            RegisterUitility<IStorage>(new PlayerPrefsStorage());
            RegisterModel<ICounterModel>(new CounterModel());
        }
    }
}