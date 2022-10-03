namespace ThangChiba.DesignPattern
{
    class MultiplyTwoObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is StatSubject)
            {
                ((StatSubject)subject).Value *= 2;
            }
        }
    }
}