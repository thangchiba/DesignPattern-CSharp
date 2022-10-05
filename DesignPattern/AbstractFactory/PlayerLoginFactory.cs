using System;
namespace AbstractFactoryPractice
{
    public class PlayerLoginFactory : IAbstractFactory
    {
        public PlayerLoginFactory()
        {
        }

        public ICharacter CreateMinion()
        {
            return new BabySkeleton();
        }

        public ICharacter CreatePlayer()
        {
            return new Player();
        }
    }
}

