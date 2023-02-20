using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 7f;
    public float padding = 0.5f;
    public Animator animator;
    private float minX;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * speed, rb.velocity.y);
        if(dirX==0)
            animator.SetBool("isMoving", false);
        else
            animator.SetBool("isMoving", true);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 10f);
        }
        //Left edge of the screen block
        // float distance = transform.position.z - Camera.main.transform.position.z;
        // Vector3 leftmost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        // minX = leftmost.x + padding;
        // if (transform.position.x < minX)
        // {
        //     transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        // }
    }
}
