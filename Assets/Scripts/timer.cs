using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class timer : MonoBehaviour
{
    [SerializeField]
    Image slider;

    [SerializeField]
    GameObject loosingMenu;

    [SerializeField]
    GameObject winningMenu;

    float timeRemaining = 60;
    private void Awake()
    {
        slider.fillAmount = 1f;
    }
    void Update()
    {
        if(StarShooter.count == 0)
        {
            StartCoroutine(won(2));
        }
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            slider.fillAmount = timeRemaining/60;
        }
        else
        {
            if (StarShooter.count != 0)
                lost();
        }
    }

    void lost()
    {
        Time.timeScale = 0;
        loosingMenu.SetActive(true);
    }
     IEnumerator won(float t)
    {

        yield return new WaitForSeconds(t);
        Time.timeScale = 0;
        winningMenu.SetActive(true);
    }


}
