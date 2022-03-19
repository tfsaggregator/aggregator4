namespace aggregator.cli;

public interface IFooService
{
    void DoCoolStuff();
}

public class FooService : IFooService
{
    public void DoCoolStuff()
    {
        System.Console.WriteLine("Cool Stuff");
    }
}
