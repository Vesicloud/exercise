namespace ConsoleApp2;

public class Tool
{
    public string Brand  { get; set; }
    public string Name { get; set; }
    public string GetFullDescription() 
    {
        return $"{Brand} {Name}";
    }
 
}