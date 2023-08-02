using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Simple Custom Movement Behaviour
[RequireComponent(typeof(Rigidbody))]
public class SimpleCustomMovement : MonoBehaviour
{
    
    [SerializeField]
    private float _speed = 10f;
    [SerializeField]
    private float _rotationSpeed = 100f;
    
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * _speed * vertical * Time.deltaTime);
        transform.Rotate(Vector3.up * _rotationSpeed * horizontal * Time.deltaTime);
    }
}
