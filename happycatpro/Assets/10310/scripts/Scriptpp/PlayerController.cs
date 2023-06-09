using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool isGround;
    Rigidbody2D rigid;
    public float force = 5f;
    public float speed = 5f;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Jump();
        Move();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGround = true;
        }
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            rigid.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            isGround = false;
        }
        else if (Input.GetKeyDown(KeyCode.W) && isGround == true)
        {
            rigid.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            isGround = false;
        }
    }
    void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
