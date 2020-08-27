using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 10f;

    GameManager Gm;
    void Start()
    {
        Gm = GameObject.FindObjectOfType<GameManager>();
        Rigidbody2D Rb = GetComponent<Rigidbody2D>();
        Rb.velocity = new Vector2(0f, Speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Gm.AddScore();
        Destroy(gameObject);
    }

}
