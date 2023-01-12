using FrameworkDesign.Practice;
using UnityEngine;

namespace FrameworkDesignPractice.Scripts
{
    public class PointGame :Architecture<PointGame>
    {
        protected override void Init()
        {
            Register<IGameModel>(new GameModel());
        }
    }
}