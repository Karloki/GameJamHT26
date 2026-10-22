using UnityEngine;

public class Player : MonoBehaviour
{
    private const int NUMBER_OF_ABILITIES_IN_GAME = 1;

    private int health;
    [SerializeField] private float moveSpeed = 5f;
    private Ability[] unlockedAbilities = new Ability[NUMBER_OF_ABILITIES_IN_GAME];
    private Transform transform;


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
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);

    }

    public void IncreaseMoveSpeed(float percent)
    {
        moveSpeed *= 1f + percent;
    }

}
