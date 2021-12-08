using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletEqui : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public Vector2 direction;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

   
}
