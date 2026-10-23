using UnityEngine;

public class Player : MonoBehaviour
{
    private const int NUMBER_OF_ABILITIES_IN_GAME = 1;

    private int health;
    private int XP;
    [SerializeField] private float moveSpeed = 5f;
    private Ability[] unlockedAbilities = new Ability[NUMBER_OF_ABILITIES_IN_GAME];
    private Transform transform;

private Animator animator;
    private SpriteRenderer spriteRenderer;

    private Vector2 movement;


    void addAbility(Ability ability)
    {
        for (int i = 0; i < NUMBER_OF_ABILITIES_IN_GAME; i++)
        {
            if (unlockedAbilities[i] != null)
            {
                unlockedAbilities[i] = ability;
            }
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform = GetComponent<Transform>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (animator == null)
            Debug.LogError("Animator component not found!", this);

        if (spriteRenderer == null)
            Debug.LogError("SpriteRenderer component not found!", this);
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement = movement.normalized;

        animator.SetFloat("Speed", movement.magnitude);

        if (movement.x < 0)
            spriteRenderer.flipX = true;
        else if (movement.x > 0)
            spriteRenderer.flipX = false;
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);

    }

    public void addXP()
    {
        XP += 1;
    }
}
