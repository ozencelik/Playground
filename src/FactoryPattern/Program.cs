
//Example to Understand Thraed-Safe Singleton Design Pattern using Eager Loading
//When use in a Multithreaded Environment

//The following Code will Invoke both methods Parallely using two different Threads
using FactoryPattern.Models;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        int fb = 0;
        int bjk = 3;
        Soccer soccer = new Soccer(); //instantiate the creator class that is responsible for creating objects
        var outcomes = soccer.Create(fb, bjk); //creating the object. 

        foreach (var outcome in outcomes)
            outcome.Print();

        Console.ReadLine();
    }
}
