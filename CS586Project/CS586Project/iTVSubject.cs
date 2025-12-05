namespace CS586Project
{
    public interface iTVSubject
    {
        void Attach(iTVObserver observer);
        void Detach(iTVObserver observer);
        void Notify();

    }
}