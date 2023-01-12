using System.Drawing;
using FrameworkDesign.Practice;
using UnityEngine;

namespace FrameworkDesignPractice.Scripts.Command
{
    public class KillEnemyCommand : ICommand
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