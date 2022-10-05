using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExam
{
    internal abstract class CharacterCreator : ICreator<Character>
    {
        public abstract Character FactoryMethod();
        public void CreateCharacterMethod()
        {
            var instance = FactoryMethod();
            instance.ShowClassName();
        }
    }
}
