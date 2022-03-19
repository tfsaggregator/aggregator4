using CommandDotNet;
using CommandDotNet.DataAnnotations;
using CommandDotNet.IoC.MicrosoftDependencyInjection;
using CommandDotNet.NameCasing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace aggregator.cli;

static class Program
{
    static int Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection
            // general services here
            .AddTransient<IGreeter, ConsoleGreeter>()
            .AddTransient<IFooService, FooService>()
            ;
        // configure command line parsing
        var appRunner = new AppRunner<Commands.RootCommand>();
        appRunner
            .UseDefaultMiddleware()
            .UseDataAnnotationValidations(showHelpOnError: true)
            .UseNameCasing(Case.KebabCase)
            .UseDefaultsFromEnvVar();
        // integrate DI with command line parsing
        foreach ((Type type,_) in appRunner.GetCommandClassTypes())
        {
            serviceCollection.AddTransient(type);
        }
        appRunner
            .UseMicrosoftDependencyInjection(serviceCollection.BuildServiceProvider());
        // here we go
        return appRunner.Run(args);
    }
}
