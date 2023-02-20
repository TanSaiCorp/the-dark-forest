using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatonFlipEnemyController : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (player.position.x <=transform.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (player.position.x >= transform.position.x)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
