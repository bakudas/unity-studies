using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Decorator study
// https://djesusnet.medium.com/design-patterns-c-aprendendo-decorator-pattern-em-net-core-5e62c4a30814
public class PizzaTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IFlavourable pizza = new Pizza();
        IFlavourable baconPizza = new BaconDecorator(pizza);
        IFlavourable onionPizza = new OnionDecorator(baconPizza);
        
        Debug.Log(baconPizza.SearchPizzaFlavour());
        Debug.Log(onionPizza.SearchPizzaFlavour());
    }

}
