using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private float Jump;

    private Animator anim;
    private Rigidbody2D rb;

    private Vector2 _jumpForce;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        _jumpForce = Vector2.up * Jump;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(_jumpForce, ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate()
    {
        float direction = Input.GetAxisRaw("Horizontal");

        anim.SetInteger("direction", (int) direction);

        rb.velocity = new Vector2(direction * Speed, rb.velocity.y);

        if (direction > 0)
        {
            transform.eulerAngles = Vector3.zero;
        } else if (direction < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
}
