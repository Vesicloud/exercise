namespace ConsoleApp2;

public class Embedded : Machine
{
    public string Context { get; set; }
    public Embedded(DateOnly date, double effect, string context) : base(date, effect)
    {
        Context = context;
    }

    public override string Operate() => $"Operating automatically in the context of: {Context}.";
}