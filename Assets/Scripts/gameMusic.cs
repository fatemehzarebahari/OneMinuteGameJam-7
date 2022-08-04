using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMusic : MonoBehaviour
{

    [SerializeField]
    AudioSource gameMusic1;
    void Start()
    {
        gameMusic1.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
            gameMusic1.volume = 0;
    }
}
