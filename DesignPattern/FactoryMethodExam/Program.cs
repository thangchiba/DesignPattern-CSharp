using FactoryMethodExam;
using System;

namespace ThangChiba.DesignPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            CharacterCreator playerCreator = new PlayerCreator();
            playerCreator.CreateCharacterMethod();
            CharacterCreator minionCreator = new MinionCreator();
            minionCreator.CreateCharacterMethod();
        }
    }
}