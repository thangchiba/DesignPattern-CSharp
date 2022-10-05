using FactoryMethodExam;

namespace ThangChiba.DesignPattern
{
    internal class MinionCreator : CharacterCreator
    {
        public override Character FactoryMethod()
        {
            return new Minion();
        }
    }
}