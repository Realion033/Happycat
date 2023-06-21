using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSPS : MonoBehaviour
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
        Jumpp();
        Movep();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGround = true;
        }
    }
    void Jumpp()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGround == true)
        {
            rigid.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            isGround = false;
        }
    }
    void Movep()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
