using UnityEngine;

namespace unity_learn.polymorphism
{
    public class Apple : Fruit
    {
        public Apple()
        {
            Debug.Log("2nd Apple Constructor Called");
        }

        // using new keyword to hide the parent class method
        public new void Chop()
        {
            Debug.Log("The apple has been chopped.");
        }
        
        // using override keyword to override the parent class method
        public override void SayHello()
        {
            Debug.Log("Hello, I am an apple.");
        }
    }
}