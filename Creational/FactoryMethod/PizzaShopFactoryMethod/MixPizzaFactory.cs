namespace PizzaShopFactoryMethod;
// به ازای هر محصول یک فکتوری داریم که درست نیست
public class MixPizzaFactory : IPizzaShopFactory
{
    public IPizza BakingPizza()
    {
        return new MixPizza();
    }
}