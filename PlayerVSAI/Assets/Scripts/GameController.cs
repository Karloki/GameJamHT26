using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] protected EnemySpawner enemySpawner;
    private int enemiesKilledThisRound = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void updateEnemiesKilledThisRound(int enemiesKilled)
    {
        enemiesKilledThisRound += enemiesKilled;
    }

    // Update is called once per frame
    void Update()
    {
        if(enemiesKilledThisRound > 50)
        {
            abilityUpgradeSequence();
        }
    }

    void abilityUpgradeSequence()
    {

    }
}
