using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlAwardBox : MonoBehaviour
{
    [SerializeField]
    float waitingTime = 10f;

    [SerializeField]
    GameObject awardBoxPrefab;

    GameObject newAwardBox;


    float currentTime;
    float appearenceTime;
    bool check = false;
    void Awake()
    {
        currentTime = 0f;
        System.Random rnd = new System.Random();
        appearenceTime = rnd.Next(0, 60);
        newAwardBox = Instantiate(awardBoxPrefab);
        newAwardBox.SetActive(false);
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
        newAwardBox.SetActive(true);
        yield return new WaitForSeconds(waitingTime);
        Destroy(newAwardBox);
    }
}
