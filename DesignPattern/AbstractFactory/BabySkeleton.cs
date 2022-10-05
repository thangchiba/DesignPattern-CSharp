using System;
namespace AbstractFactoryPractice
{
    public class BabySkeleton : Minion
    {
        public BabySkeleton()
        {
        }

        public override void ShowName()
        {
            base.ShowName();
            Console.WriteLine("Im BabySkeleton");
        }
    }
}

