using FactoryMethodExam;

namespace ThangChiba.DesignPattern
{
    internal class MinionCreator : CharacterCreator
    {
        public override Character FactoryMethod()
        {
            Console.WriteLine("Setup experience receive when defeat minion");
            return new Minion();
        }
    }
}