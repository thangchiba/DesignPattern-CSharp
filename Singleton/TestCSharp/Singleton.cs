using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{
    public sealed class Singleton
    {
        private static Lazy<int> count = new Lazy<int>(() => 0);
        public static int Count
        {
            get { return count.Value; }
            set { count = new Lazy<int>(() => value); }
        }

        private static Lazy<Player> mainPlayer = new Lazy<Player>(()=> new Player("123","Thang"));
        public static Lazy<Player> MainPlayer { get => mainPlayer; set => mainPlayer = value; }
    }
}
