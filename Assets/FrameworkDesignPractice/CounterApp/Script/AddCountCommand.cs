using FrameworkDesignPractice;
using UnityEngine;

namespace FrameworkDesign.Practice
{
    public class AddCountCommand : ICommand
    {
        public void Execute()
        {
            CounterApp.Get<ICounterModel>().Count.Value++;
        }
    }
}