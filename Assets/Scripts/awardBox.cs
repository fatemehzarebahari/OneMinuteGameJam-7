using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awardBox : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StarShooter.DestroyAll();
    }
    
}
