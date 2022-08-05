using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyTime : MonoBehaviour
{
    [SerializeField]
    private float time;

    private void Awake()
    {
        StartCoroutine(DestroyLine());
    }
    public float getTime() 
    {
        return time;
    }

    public IEnumerator DestroyLine()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
