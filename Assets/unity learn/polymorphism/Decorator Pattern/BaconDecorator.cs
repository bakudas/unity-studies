// Concrete Decorator
public class BaconDecorator : PizzaDecorator
{
    public BaconDecorator(IFlavourable flavour) : base(flavour)
    {
        
    }

    public override string SearchPizzaFlavour()
    {
        var flavour = base.SearchPizzaFlavour();
        flavour += "\r\n com extra de bacon!";
        return flavour;
    }
}
