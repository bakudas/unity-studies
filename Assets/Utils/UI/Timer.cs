using UnityEngine;
using UnityEngine.UI;

namespace Utils.UI
{
    public class Timer : MonoBehaviour
    {
        private Text _timerText;
        private float _timeSlapped = 0f;
    
        // Start is called before the first frame update
        void Start()
        {
            _timerText = GetComponent<Text>();
            _timeSlapped = 0f;
        }

        void FixedUpdate()
        {
            _timeSlapped += Time.deltaTime;
            _timerText.text = _timeSlapped.ToString("00");
        }
    }
}
