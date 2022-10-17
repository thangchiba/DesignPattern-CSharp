using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class ColorRed : IColor
    {
        public string GetColor()
        {
            return "Red";
        }
    }
}
