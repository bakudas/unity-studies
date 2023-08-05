using UnityEngine;

namespace unity_learn.SOLID.Single_Responsibility
{
    public class UnrefactoredPlayer : MonoBehaviour
    {

        [SerializeField] private string inputAxis;
        [SerializeField] private float positionMultiplier;
        private float _position;
        private AudioSource m_BouncerSfx;
    
        // Start is called before the first frame update
        void Start()
        {
            m_BouncerSfx = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            float delta = Input.GetAxis(inputAxis) * Time.deltaTime;
        
            _position += delta * positionMultiplier;
        
            transform.position = new Vector3(_position, transform.position.y, transform.position.z);
        }
    
        private void OnCollisionEnter(Collision other)
        {
            m_BouncerSfx.Play();
        }
    }    
}

