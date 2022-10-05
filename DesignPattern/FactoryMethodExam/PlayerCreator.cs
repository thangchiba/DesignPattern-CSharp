﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExam
{
    internal class PlayerCreator : CharacterCreator
    {
        public override Character FactoryMethod()
        {
            return new Player();
        }
    }
}
