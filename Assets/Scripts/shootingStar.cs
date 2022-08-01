using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingStar : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    float speed = 1;

    [SerializeField]
    float yDirection = -10;

    [SerializeField]
    float xDirection = -10;
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Vector2 v = new Vector2(xDirection, yDirection);
        rb.velocity = speed * v;
    }
}
