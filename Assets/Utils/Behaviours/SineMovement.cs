using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Simple sine movement Behaviour
public class SineMovement : MonoBehaviour
{
    private float _time = 0f;
    [SerializeField]
    private float _speed = 1f;
    [SerializeField]
    private float _amplitude = 1f;
    [SerializeField]
    private float _frequency = 1f;
    [SerializeField]
    private Vector3 _direction = Vector3.up;
    
    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        transform.Translate(_direction * _amplitude * Mathf.Sin(_frequency * _time) * _speed * Time.deltaTime);
    }
}
