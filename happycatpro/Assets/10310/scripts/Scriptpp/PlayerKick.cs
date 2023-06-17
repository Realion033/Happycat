using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKick : MonoBehaviour
{
    Animator anime;
    public float shootForce = 100f;
    public GameObject ball;
    Rigidbody2D rbBall;
    bool isKick;
    Vector3 dirVec;

    void Start()
    {
        anime = GetComponent<Animator>();
        ball = GameObject.FindWithTag("Ball");
        rbBall = ball.GetComponent<Rigidbody2D>();
        isKick = false;
    }

    void Update()
    {
        Kick();
    }

    void Kick()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            anime.SetBool("isKick", true);
            isKick = true;
        }
    }

    public void AnimeEndEvent()
    {
        anime.SetBool("isKick", false);
        isKick = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isKick == true)
        {
            dirVec = (ball.transform.position - transform.position).normalized;
            rbBall.AddForce(dirVec * shootForce, ForceMode2D.Force);
        }
    }
}
