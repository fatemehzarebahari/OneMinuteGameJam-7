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

    public void Shoot(float xDirection,float yDirection)
    {
        Vector2 v = new Vector2(xDirection, yDirection);
        rb.velocity = speed * v;
    }
}
