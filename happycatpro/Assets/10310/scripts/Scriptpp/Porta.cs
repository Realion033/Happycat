using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    GameObject ball;
    public Rigidbody2D ballrb;

    private void Awake()
    {
        ball = GameObject.FindWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            ball.transform.position = new Vector3(0, 1, 0);
            ballrb.velocity = Vector2.zero;
            
        }
    }
}
