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

    [SerializeField]
    AudioSource wonAudio;

    [SerializeField]
    AudioSource loseAudio;



    float timeRemaining = 60;
    private void Awake()
    {
        slider.fillAmount = 1f;
    }
    void Update()
    {
        print(StarShooter.count);
        if(StarShooter.count <= 0)
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
                StartCoroutine(lost(0.5f));
        }
    }

    IEnumerator lost(float t)
    {
        yield return new WaitForSeconds(t);
        Time.timeScale = 0;
        loseAudio.Play();

        loosingMenu.SetActive(true);
    }
     IEnumerator won(float t)
    {

        yield return new WaitForSeconds(t);
        Time.timeScale = 0;
        wonAudio.Play();
        winningMenu.SetActive(true);

    }


}
