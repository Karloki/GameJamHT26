
using UnityEngine;

public class WalkerEnemy : BaseEnemy
{
    private Transform target;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    private Vector3 previousPosition;



    void Start()
    {
        base.Start();

        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
            target = player.transform;

        // Look for components on this object first.
        // If your graphics are on a child, see the note below.
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        previousPosition = transform.position;

        if (animator == null)
            Debug.LogError("WalkerEnemy: Animator not found!", this);

        if (spriteRenderer == null)
            Debug.LogError("WalkerEnemy: SpriteRenderer not found!", this);
    }

    void Update()
    {
        if (target == null)
        {
            if (animator != null)
                animator.SetFloat("Speed", 0f);

            return;
        }

        // Chase the player.
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            moveSpeed * Time.deltaTime
        );

        // Determine actual movement speed.
        float actualSpeed =
            (transform.position - previousPosition).magnitude
            / Mathf.Max(Time.deltaTime, 0.0001f);

        previousPosition = transform.position;

        // Update idle/walk animation.
        if (animator != null)
            animator.SetFloat("Speed", actualSpeed);

        // Face the player horizontally.
        float horizontalDifference =
            target.position.x - transform.position.x;

        if (spriteRenderer != null)
        {
            if (horizontalDifference < -0.01f)
                spriteRenderer.flipX = true;
            else if (horizontalDifference > 0.01f)
                spriteRenderer.flipX = false;
        }
    }
}

