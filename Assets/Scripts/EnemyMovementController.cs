using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    public Transform player;
    public float speed = 2f;
    public float range = 5f;
    public float stopDistance = 1.5f;
    public float attackDistance = 1.5f;
    public float attackCooldown = 1f;
    private bool isAttacking = false;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) < range)
        {
            // move towards the player
            Vector2 direction = (player.position - transform.position).normalized;
            float distance = Vector2.Distance(transform.position, player.position);
            if (distance > stopDistance)
            {
                animator.SetBool("isMoving", true);
                animator.SetBool("isAttacking", false);
                transform.Translate(direction * speed * Time.deltaTime);
            }
            else if (!isAttacking && distance <= attackDistance)
            {
                animator.SetBool("isMoving", false);
                // stop moving and start attacking if close enough
                isAttacking = true;
                Invoke("DoAttack", attackCooldown);
            }
        }
        else
        {
            animator.SetBool("isAttacking", false);
            animator.SetBool("isMoving", false);
            // idle or patrol
        }
    }
    void DoAttack()
    {
        animator.SetBool("isAttacking", true);
        isAttacking = false;
    }
}
