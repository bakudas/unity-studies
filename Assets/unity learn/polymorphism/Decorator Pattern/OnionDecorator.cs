// Concrete Decorator
public class OnionDecorator : PizzaDecorator
{
    public OnionDecorator(IFlavourable flavour) : base(flavour)
    {
        
    }

    public override string SearchPizzaFlavour()
    {
        var flavour = base.SearchPizzaFlavour();
        flavour += "\r\n com extra de cebola!";
        return flavour;
    }
}