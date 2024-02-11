
//SRP and OCP نقض می شود
public class PizzaSimpleFactory
{
    public IPizaa BakingPizza(TypeOfPizza typeOfPizza)
    {
        return typeOfPizza switch 
        {
            TypeOfPizza.Mix=> new MixPizza(),
            TypeOfPizza.Special=> new SpecialPizza(),
            _=> throw new ArgumentException("")
        };
    }
}