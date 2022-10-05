using System;
namespace AbstractFactoryPractice
{
    public class Player : ICharacter
    {
        public Player()
        {
        }

        public virtual void ShowName()
        {
            Console.WriteLine("My name is Player");
        }
    }
}

