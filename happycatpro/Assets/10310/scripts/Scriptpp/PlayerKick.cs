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
    bool isLawKick;
    Vector3 dirVec;

    void Start()
    {
        anime = GetComponent<Animator>();
        ball = GameObject.FindWithTag("Ball");
        rbBall = ball.GetComponent<Rigidbody2D>();
        isKick = false;
        isLawKick = false;
    }

    void Update()
    {
        Kick();
        LawShoot();
    }

    void Kick()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            anime.SetBool("isKick", true);
            isKick = true;
        }
    }
    void LawShoot()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            anime.SetBool("isKick", true);
            isLawKick = true;
        }
    }

    public void AnimeEndEvent()
    {
        anime.SetBool("isKick", false);
        isKick = false;
        isLawKick = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isKick == true && collision.CompareTag("Ball"))
        {
            dirVec = (ball.transform.position - transform.position).normalized;
            rbBall.AddForce(dirVec * shootForce, ForceMode2D.Force);
        }
        if(isLawKick == true && collision.CompareTag("Ball"))
        {
            rbBall.AddForce(Vector2.right * shootForce, ForceMode2D.Force);
        }
    }
}
