using FrameworkDesign.Example;
using UnityEngine;

namespace FrameworkDesign.Example
{
    public struct KillEnemyCommand : ICommand
    {
        public void Execute()
        {
            PointGame.Get<IGameModel>().killCount.Value++;
            
            if (PointGame.Get<IGameModel>().killCount.Value == 10)
            {
                GamePassEvent.Trigger();
            }
        }
    }
}