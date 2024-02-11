namespace PizzaShopFactoryMethod;


// به ازای هر محصول یک فکتوری داریم کهه درست نیست
public class SpecialPizzaFactory : IPizzaShopFactory
{
    public IPizza BakingPizza()
    {
        return new SpecialPizza();
    }
}