using System.Collections;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

// First Countdown implementation

// public class CountDown : MonoBehaviour
// {
//     private Text _countDownText;
//     private float _timeCountDown = 3f;
//     
//     // Start is called before the first frame update
//     void Start()
//     {
//         _countDownText = GetComponent<Text>();
//         _countDownText.text = _timeCountDown.ToString("0");
//     }
//
//     private void FixedUpdate()
//     {
//         _timeCountDown -= Time.deltaTime;
//         _countDownText.text = _timeCountDown.ToString("0");
//         if (!(_timeCountDown <= 0)) return;
//         _countDownText.text = "Let's Play!";
//         Destroy(gameObject, 1f);
//     }
// }


// Second Countdown implementation with a coroutine
namespace Utils.UI
{
    public class CountDown : MonoBehaviour
    {
        [CanBeNull] private Text _countDownText = null;
        [SerializeField]
        private float timeCountDown = 3f;
    
        // Start is called before the first frame update
        void Start()
        {
            _countDownText = GetComponent<Text>();
            StartCoroutine(CountDownCoroutine());
        }

        private IEnumerator CountDownCoroutine()
        {
            while (timeCountDown > 0)
            {
                _countDownText.text = timeCountDown.ToString("0");
                yield return new WaitForSeconds(1f);
                timeCountDown--;
            }
            _countDownText.text = "Let's Play!";
            Destroy(gameObject, 1f);
        }
    }
}