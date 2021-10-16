using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] float jumpForce = 15f;
    bool isGrounded = true;

    Rigidbody2D rb;
    Animator anim;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void HandleJump()
    {
        rb.velocity = Vector2.up * jumpForce;
        anim.SetTrigger("Jump");
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded) HandleJump();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor")) isGrounded = true;
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor")) isGrounded = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy")) GameManager.instance.GameOver();
    }
}
