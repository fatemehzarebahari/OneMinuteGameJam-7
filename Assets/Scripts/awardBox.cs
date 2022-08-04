using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awardBox : MonoBehaviour
{
    [SerializeField]
    AudioSource openBox;
    void OnCollisionEnter2D(Collision2D collision)
    {
        openBox.Play();
        StarShooter.DestroyAll();
    }
    
}
