namespace ThangChiba.DesignPattern
{
    class PlusOneObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is StatSubject)
            {
                ((StatSubject)subject).Value += 1;
            }
        }
    }
}