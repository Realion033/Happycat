using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour
{

    public float force = 100f;
    public GameObject ball;
    Rigidbody2D rbBall;

    void Start()
    {

        ball = GameObject.FindGameObjectWithTag("Ball");
        rbBall = ball.GetComponent<Rigidbody2D>();

        this.enabled = false;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (collision.gameObject.tag == "Ball")
            {

                Vector2 pos = (transform.position - collision.gameObject.transform.position).normalized;
                rbBall.AddForce(-pos * force, ForceMode2D.Impulse);
            }
        }
    }
}
