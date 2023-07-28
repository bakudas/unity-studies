using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // This is the same as calling ExtensionMethods.ResetTransform(transform);
        transform.ResetTransform();        
    }

}
