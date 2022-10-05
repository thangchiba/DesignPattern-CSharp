using System;
namespace BuilderPattern
{
    public class Minion : ICharacter
    {
        public Minion()
        {
        }

        public virtual void ShowName()
        {
            Console.WriteLine("My name is Minion");
        }
    }
}

