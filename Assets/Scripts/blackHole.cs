using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackHole : MonoBehaviour
{
    [SerializeField]
    Animator snail;

    [SerializeField]
    float time = 2f;

    [SerializeField]
    AudioSource happyOctupus;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        happyOctupus.Play();
        snail.SetTrigger("hide");
        StarShooter.removeStar(collision.gameObject);
        Destroy(collision.gameObject);

        if (StarShooter.count > 0)
        {
            StartCoroutine(getUp(time));
        }
    }

    IEnumerator getUp(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        snail.SetTrigger("getUp");

    }
}
