namespace BearAdapter
{
    public interface IBear
    {
        bool Hibernating { get; }

        void Roar();
        void LookAt(object objectToLookAt);
        void GoTowards(object objectToWalkTowards);
        bool TryEat(object objectToEat);
    }
}
