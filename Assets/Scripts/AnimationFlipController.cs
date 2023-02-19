using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationFlipController : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        if (moveHorizontal < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (moveHorizontal > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
