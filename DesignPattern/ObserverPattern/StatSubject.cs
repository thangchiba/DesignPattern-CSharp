namespace ThangChiba.DesignPattern
{
    public class StatSubject : ISubject
    {
        private float value;
        public float Value { get => value; set => this.value = value; }

        public StatSubject(float value)
        {
            this.value = value;
        }

        List<IObserver> modifyObservers = new List<IObserver>();


        public void Attach(IObserver observer)
        {
            modifyObservers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            if (modifyObservers.Contains(observer))
                modifyObservers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine($"We have {modifyObservers.Count} modifies");
            foreach (var observer in modifyObservers)
            {
                observer.Update(this);
            }
            Console.WriteLine($"The value is {value}");
        }
    }
}
