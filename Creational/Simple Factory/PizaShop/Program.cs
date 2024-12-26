// See https://aka.ms/new-console-template for more information


var factory = new PizzaSimpleFactory();
var mix= factory.BakingPizza(TypeOfPizza.Mix);
var special= factory.BakingPizza(TypeOfPizza.Special);

Console.WriteLine(mix.ToString());
Console.WriteLine(special.ToString());
