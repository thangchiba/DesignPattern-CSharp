using FactoryMethodExam;
using System;

namespace ThangChiba.DesignPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            ClientMethod(new PlayerCreator());
            ClientMethod(new MinionCreator());
        }

        static void ClientMethod(CharacterCreator creator)
        {
            creator.CreateCharacterMethod();
        }
    }
}