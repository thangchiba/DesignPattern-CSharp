using System;
namespace BuilderPattern
{
    public class Boss : Minion
    {
        public Boss()
        {
        }

        public override void ShowName()
        {
            base.ShowName();
            Console.WriteLine("Im boss");
        }
    }
}

