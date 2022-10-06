namespace PrototypePattern
{
    public class Program
    {
        public static void Main()
        {
            Minion minion1 = new Minion(1);
            Minion minion2 = minion1.DeepCopy();
            Minion minion3 = minion1.ShallowCopy();
            Console.WriteLine(minion1);
            Console.WriteLine(minion2);
            Console.WriteLine(minion3);
        }
    }
}