using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameworkDesign.Example
{
    public interface IGameModel : IBelongToArchitecture
    {
        BindableProperty<int> killCount { get;}
        BindableProperty<int> Gold { get;}
        BindableProperty<int> Score { get;}
        BindableProperty<int> BestScore { get;}
    }
    
    /// <summary>
    /// 模型与数据分离
    /// </summary>
    public class GameModel :IGameModel
    {
        public BindableProperty<int> killCount { get; } = new BindableProperty<int>() { Value = 0 };
        public BindableProperty<int> Gold { get; } = new BindableProperty<int>() { Value = 0 };
        public BindableProperty<int> Score { get; } = new BindableProperty<int>() { Value = 0 };
        public BindableProperty<int> BestScore { get; } = new BindableProperty<int>() { Value = 0 };
        public IArchitecture Architecture { get; set; }
    }
}