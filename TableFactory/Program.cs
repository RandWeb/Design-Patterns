// See https://aka.ms/new-console-template for more information
var metalFactory = new MetalFactory();
var carpenterFactory = new CarpenterFactory();
Console.WriteLine(metalFactory.CreateChair());
Console.WriteLine(metalFactory.CreateTable());
Console.WriteLine(carpenterFactory.CreateChair());
Console.WriteLine(carpenterFactory.CreateTable());