using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    Vector2 movement;
    void Start()
    {
        
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if ((Input.GetAxis("Vertical") > 0) && (Input.GetAxis("Horizontal")>0) || (Input.GetAxis("Vertical")< 0) && (Input.GetAxis("Horizontal")<0) || (Input.GetAxis("Vertical")< 0) && (Input.GetAxis("Horizontal")>0) || (Input.GetAxis("Vertical")> 0) && (Input.GetAxis("Horizontal")<0))
        {
            rb.MovePosition(rb.position + movement * moveSpeed * 0.7f * Time.fixedDeltaTime);
        } else {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Screw"))
        {
            Destroy(other.gameObject);
        }
    }
}
