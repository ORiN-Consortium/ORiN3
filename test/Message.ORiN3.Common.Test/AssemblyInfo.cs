using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal static class Ininializer
{
    [ModuleInitializer]
    public static void Initialize()
    {
        Console.WriteLine($"starting => {Assembly.GetExecutingAssembly().GetName()}");
    }
}
