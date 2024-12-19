namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestClass tc = new TestClass("Bob");
            Console.WriteLine($"Hello, {tc.Name}");
        }
    }
}
