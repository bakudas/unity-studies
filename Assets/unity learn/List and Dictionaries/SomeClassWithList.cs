using System.Collections.Generic; // Required when working with Lists or Dictionaries
using UnityEngine;

namespace unity_learn.List_and_Dictionaries
{
    public class SomeClassWithList : MonoBehaviour
    {
        // This is a generic list of type BadGuy
        List<BadGuy> badguys = new List<BadGuy>();
        
        void Start()
        {
            // This is how you create a new entry in a list. You can also use new List<BadGuy>() {new BadGuy(), new BadGuy()}
            badguys.Add(new BadGuy("Harvey", 50));
            badguys.Add(new BadGuy("Magneto", 100));
            badguys.Add(new BadGuy("Pip", 5));
            
            badguys.Sort(); // This sorts the list. The badguys will be sorted by their power levels from lowest to highest.
            
            // This clears out the list so that it is empty.
            foreach (BadGuy guy in badguys)
            {
                print(guy.name + " " + guy.power);
            }
            
            badguys.Clear();
        }
    }
}