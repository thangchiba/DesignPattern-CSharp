namespace ThangChiba.DesignPattern
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}