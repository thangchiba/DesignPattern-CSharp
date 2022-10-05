using System;
namespace AbstractFactoryPractice
{
    public class PlayerChangeSceneFactory : IAbstractFactory
    {
        public PlayerChangeSceneFactory()
        {
        }

        public ICharacter CreateMinion()
        {
            return new Boss();
        }

        public ICharacter CreatePlayer()
        {
            return new Player();
        }
    }
}

