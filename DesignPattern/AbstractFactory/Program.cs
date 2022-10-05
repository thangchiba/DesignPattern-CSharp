namespace AbstractFactoryPractice
{
    public class AbstractFactory
    {
        public static void Main()
        {
            //When player login. Create a babyskeleton as minion.
            ClientMethod(new PlayerLoginFactory());

            Console.WriteLine("*****************");

            //When player login. Create a boss as minion.
            ClientMethod(new PlayerChangeSceneFactory());
        }
        public static void ClientMethod(IAbstractFactory factory)
        {
            factory.CreatePlayer().ShowName();
            factory.CreateMinion().ShowName();
        }
    }
}