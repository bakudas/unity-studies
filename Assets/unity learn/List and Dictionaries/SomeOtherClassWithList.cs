using System;
using System.Collections.Generic;
using UnityEngine;

namespace unity_learn.List_and_Dictionaries
{
    public class SomeOtherClassWithList : MonoBehaviour
    {
        private void Start()
        {
            // This is how you create a Dictionary. Notice how this takes two generic terms.
            // In this case you are using a string and a BadGuy as your two values.
            Dictionary<string, BadGuy> badGuys = new Dictionary<string, BadGuy>();
            
            BadGuy bg1 = new BadGuy("Harvey", 50);
            BadGuy bg2 = new BadGuy("Magneto", 100);
            
            // You can place variables into the Dictionary with the Add() method.
            badGuys.Add("gangster", bg1);
            badGuys.Add("mutant", bg2);
            
            BadGuy magneto = badGuys["mutant"]; // badGuys["mutant"] returns bg2, the BadGuy object associated with "mutant".

            BadGuy temp = null;
            
            // This is a safer, but slow, method of accessing values in a dictionary.
            if (badGuys.TryGetValue("bird", out temp))
            {
                // success!
            }
            else
            {
                // failure!
            }

        }
    }
}