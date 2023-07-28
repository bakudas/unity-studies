using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClassExample : MonoBehaviour
{
    private void Start()
    {
        GenericClass<int> myIntClass = new GenericClass<int>();
        Debug.Log(myIntClass.item);
        myIntClass.UpdateItem(5);
        Debug.Log(myIntClass.item);
    }
}
