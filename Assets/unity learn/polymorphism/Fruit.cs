using Unity.VisualScripting;
using UnityEngine;

namespace unity_learn.polymorphism
{
    public class Fruit : IChopable
    {
        public Fruit()
        {
            Debug.Log("1rs Fruit Constructor Called");
        }

        // method that can be called by child class
        // use new keyword to hide the parent class method
        public void Chop()
        {
            Debug.Log("The fruit has been chopped.");   
        }

        // using virtual keyword to allow child class to override this method
        public virtual void SayHello()
        {
            Debug.Log("Hello, I am a fruit.");
        }
    }
}