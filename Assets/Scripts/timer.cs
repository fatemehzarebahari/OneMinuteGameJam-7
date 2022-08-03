using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    [SerializeField]
    Image slider;

    float timeRemaining = 60;
    private void Awake()
    {
        slider.fillAmount = 1f;
    }
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            slider.fillAmount = timeRemaining/60;
        }
    }
}
