using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlAwardBox : MonoBehaviour
{
    [SerializeField]
    float waitingTime = 10f;

    [SerializeField]
    GameObject awardBox;



    float currentTime;
    float appearenceTime;
    bool check = false;
    void Awake()
    {
        currentTime = 0f;
        System.Random rnd = new System.Random();
        appearenceTime = rnd.Next(0, 60);
        awardBox.SetActive(false);
    }

    void Update()
    {
        if (currentTime < 60)
        {
            currentTime += Time.deltaTime;
        }
        if (currentTime >= appearenceTime && !check)
        {
            StartCoroutine(appearTheAwardBox());
            check = true;
        }
    }
    private IEnumerator appearTheAwardBox()
    {
        awardBox.SetActive(true);
        yield return new WaitForSeconds(waitingTime);
        Destroy(awardBox);
    }
}
