using FrameworkDesign;

namespace FrameworkDesign.Example
{
    public class PointGame : Architecture<PointGame>
    {
        protected override void Init()
        {
            RegisterModel<IGameModel>(new GameModel());
        }
    }
}