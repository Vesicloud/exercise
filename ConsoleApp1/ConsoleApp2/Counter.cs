namespace ConsoleApp2;

public class Counter : IResettable
{
    public int Count { get; set; }
    public void Reset() => Count = 0;
}