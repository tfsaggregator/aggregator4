using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregator.cli;

public interface IGreeter
{
    string Greet();
}

public class ConsoleGreeter : IGreeter
{
    private readonly IFooService _fooService;

    public ConsoleGreeter(IFooService fooService)
    {
        _fooService = fooService;
    }

    public string Greet()
    {
        _fooService.DoCoolStuff();

        return "Hello World from the Console Greeter";
    }
}
