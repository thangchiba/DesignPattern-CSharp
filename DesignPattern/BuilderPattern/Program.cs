
namespace BuilderPattern
{
    public class Program
    {
        public static void Main()
        {
            Scene scene = new SceneBuilder()
                .SecondLevelMinion(new BabySkeleton())
                .SceneName("Scene 1")
                .SceneNumber(1)
                .Build();
        }
    }
}