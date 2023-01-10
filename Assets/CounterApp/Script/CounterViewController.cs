using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using FrameworkDesign;

namespace CounterApp
{
    public class CounterViewController : MonoBehaviour
    {
        private ICounterModel mCounterModel;
        private void Start()
        {
            mCounterModel = CounterApp.Get<ICounterModel>();
            
            //使用委托
            // CounterModel.OnCountChanged += OnCountChanged;
            // //主动调用一次
            // OnCountChanged(CounterModel.Count);
            //OnCountChanged(CounterModel.Instance.Count.Value);
            OnCountChanged(mCounterModel.Count.Value);

            mCounterModel.Count.OnValueChanged += OnCountChanged;
            
            transform.Find("BtnAdd").GetComponent<Button>().onClick.AddListener(() =>
            {
                //交互逻辑
                new AddCountCommand().Execute();
            });
            
            transform.Find("BtnSub").GetComponent<Button>().onClick.AddListener(() =>
            {
                //交互逻辑
                new SubCountCommand().Execute();
            });
        }

        private void OnCountChanged(int countValue)
        {
            transform.Find("CountText").GetComponent<Text>().text = countValue.ToString();
        }

        private void OnDestroy()
        {
            // CounterModel.OnCountChanged -= OnCountChanged;
            // OnCountChangedEvent.UnRegister(OnCountChanged);
            
        }
        
    }

    // 使用委托
    
    // public class CounterModel
    // {
    //     private static int mCount = 0;
    //
    //     public static Action<int> OnCountChanged;
    //
    //     public static int Count
    //     {
    //         get => mCount;
    //         
    //         set
    //         {
    //             if (value != mCount)
    //             {
    //                 mCount = value;
    //                 OnCountChanged?.Invoke(value);
    //             }
    //             
    //         }
    //     }
    // }
    
    // //使用事件
    // public class CounterModel
    // {
    //     private static int mCount = 0;
    //     public static int Count
    //     {
    //         get => mCount;
    //         
    //         set
    //         {
    //             if (value != mCount)
    //             {
    //                 mCount = value;
    //                 OnCountChangedEvent.Trigger();
    //             }
    //             
    //         }
    //     }
    // }

    //

    public interface ICounterModel: IBelongToArchitecture
    {
        BindableProperty<int> Count { get; }
    }
    
    public class CounterModel :ICounterModel  // : Singleton<CounterModel> 
    {
        //private CounterModel(){}

        public CounterModel()
        {
            Count.Value = CounterApp.Get<IStorage>().LoadInt("COUNTER_COUNT");

            Count.OnValueChanged += count=>
            {
                CounterApp.Get<IStorage>().SaveInt("COUNTER_COUNT", count);
            };
        }
        
        public BindableProperty<int> Count { get; } = new BindableProperty<int>();

        public IArchitecture Architecture { get; set; }
    }

    // public class OnCountChangedEvent : Event<OnCountChangedEvent>
    // {
    //     
    // }
    
}