using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeading : MonoBehaviour
{
    public Rigidbody2D ballRigid;
    [SerializeField] float HeadForce = 0.05f;
    // Update is called once per frame
    private void Start()
    {

    }
    void Update()
    {

    }
    void Heading()
    {
        ballRigid.AddForce(Vector2.right * HeadForce, ForceMode2D.Impulse);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            Heading();
        }
    }
}
