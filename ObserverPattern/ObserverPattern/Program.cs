namespace ThangChiba.DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new StatSubject(100);

            IObserver observer1 = new PlusOneObserver();
            subject.Attach(observer1);
            IObserver observer2 = new MultiplyTwoObserver();
            subject.Attach(observer2);
            IObserver observer3 = new PlusOneObserver();
            subject.Attach(observer3);
            subject.Notify();
        }
    }
}