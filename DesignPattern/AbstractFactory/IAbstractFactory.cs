using System;
namespace AbstractFactoryPractice
{
    public interface IAbstractFactory
    {
        public ICharacter CreatePlayer();
        public ICharacter CreateMinion();
    }
}

