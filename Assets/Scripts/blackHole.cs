using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackHole : MonoBehaviour
{
    [SerializeField]
    Animator snail;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        snail.SetTrigger("hide");
    }
}
