namespace DDGofIterator
{
    //Iterator
    public interface IAbstractIterator
    {
        Cliente First();
        Cliente Next();
        bool IsDone { get; }
    }
}
