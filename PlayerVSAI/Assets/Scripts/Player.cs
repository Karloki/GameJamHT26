using UnityEngine;

public class Player : MonoBehaviour
{
    private const int NUMBER_OF_ABILITIES_IN_GAME = 1;

    private int health;
    private Ability[] unlockedAbilities = new Ability[NUMBER_OF_ABILITIES_IN_GAME];

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
