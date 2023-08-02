using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Simple Bullet Behaviour
public class BulletBehaviour : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
    }
}
