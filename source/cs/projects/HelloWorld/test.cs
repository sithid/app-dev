public class TestClass
{
    public string Name{ get; set; }
    public TestClass( string name )
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}