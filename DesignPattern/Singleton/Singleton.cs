using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{
    public sealed class Singleton
    {
        private static readonly object lockCount = new object();
        public static int bientam = 0;

        private static int count { get; set; } = 0;

        private static Lazy<Player> mainPlayer = new Lazy<Player>(() => new Player(123, "Thang"));
        public static Lazy<Player> MainPlayer { get => mainPlayer; set => mainPlayer = value; }

        public static Player player = new Player(0,"Thang");

        public static int GetCount()
        {
            return count;
        }
        public static void IncreaseCount()
        {
            lock (lockCount)
            {
                count++;
            }
        }
    }
}
