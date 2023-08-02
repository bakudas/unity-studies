using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Simple Rotator Behaviour
public class Rotator : MonoBehaviour
{
    [SerializeField]
    private Vector3 rotationSpeed = new Vector3();
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);    
    }
}
