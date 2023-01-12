using FrameworkDesignPractice;
using UnityEngine;

namespace FrameworkDesign.Practice
{
    public interface IGameModel
    {
        BindableProperty<int> killCount { get; }
        BindableProperty<int> Gold { get; }
        BindableProperty<int> Score { get; }
        BindableProperty<int> BestScore { get; }
    }
    
    public class GameModel:IGameModel
    {
        public BindableProperty<int> killCount { get; }= new BindableProperty<int>();
        public BindableProperty<int> Gold { get; }= new BindableProperty<int>();
        public BindableProperty<int> Score { get; }= new BindableProperty<int>();
        public BindableProperty<int> BestScore { get; }= new BindableProperty<int>();
    }
}