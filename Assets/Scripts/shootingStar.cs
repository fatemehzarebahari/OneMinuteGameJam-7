using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingStar : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    float speed = 1;
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Vector2 v = new Vector2(-10, -10);
        rb.velocity = speed * v;
    }
}
