using UnityEngine;

namespace unity_learn.SOLID.Single_Responsibility
{
    [RequireComponent(typeof(PlayerAudio), typeof(PlayerInput), typeof(PlayerMovement))]
    public class Player : MonoBehaviour
    {
        private PlayerAudio _playerAudio;
        private PlayerInput _playerInput;
        private PlayerMovement _playerMovement;
    
        // Start is called before the first frame update
        void Start()
        {
            _playerAudio = GetComponent<PlayerAudio>();
            _playerInput = GetComponent<PlayerInput>();
            _playerMovement = GetComponent<PlayerMovement>();    
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
