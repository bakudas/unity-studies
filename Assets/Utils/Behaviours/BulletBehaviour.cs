using UnityEngine;

// Simple Bullet Behaviour
public class BulletBehaviour : MonoBehaviour
{
    // Bullet speed
    [SerializeField]
    private float speed = 10f;
    // Bullet lifetime
    protected float MLifeTime = 5f;
    
    private void Start()
    {
        Destroy(gameObject, MLifeTime);
    }

    
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
    }

}

