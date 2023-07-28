using System;

namespace unity_learn.List_and_Dictionaries
{
    public class BadGuy : IComparable<BadGuy>
    {
        public string name;
        public int power;
        
        // This is the constructor for the class. It has the same name as the class and it doesn't have any return type.
        public BadGuy(string newName, int newPower)
        {
            name = newName;
            power = newPower;
        }

        public int CompareTo(BadGuy other)
        {
            if(other == null)
            {
                return 1;
            }
            
            return power - other.power;
        }
    }
}