
// Base Decorator

using UnityEngine;

public class PizzaDecorator : IFlavourable
{
    private readonly IFlavourable _flavour;

    public PizzaDecorator(IFlavourable flavour)
    {
        _flavour = flavour;
    }

    public virtual string SearchPizzaFlavour()
    {
        var flavour = _flavour.SearchPizzaFlavour();
        return flavour;
    }
}
