using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
public float Speed;
private Rigidbody2D rb;
private SpriteRenderer sprite;
   void Start()
    {
rb = GetComponent<Rigidbody2D>();
sprite = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
rb.linearVelocity = direction.normalized * Speed;
    }
}


