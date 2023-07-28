using System;
using UnityEngine;

namespace unity_learn.polymorphism
{
    public class FruitSalad : MonoBehaviour
    {
        private void Start()
        {
            //Notice here how the variable "_myFruit" is of type
            //Fruit but is being assigned a reference to an Apple. This
            //works because of Polymorphism. Since an Apple is a Fruit,
            //this works just fine. While the Apple reference is stored
            //in a Fruit variable, it can only be used like a Fruit
            Fruit myFruit = new Apple();

            myFruit.SayHello();
            myFruit.Chop();

            //This is called downcasting. The variable "_myFruit" which is 
            //of type Fruit, actually contains a reference to an Apple. Therefore,
            //it can safely be turned back into an Apple variable. This allows
            //it to be used like an Apple, where before it could only be used
            //like a Fruit.
            Apple myApple = (Apple)myFruit;

            myApple.SayHello();
            myFruit.Chop();
        }
    }
}