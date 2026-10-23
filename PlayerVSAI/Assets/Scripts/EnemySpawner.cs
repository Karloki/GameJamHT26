using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] protected GameObject enemy;
    [SerializeField] protected EnemyManager enemyManager;
    private bool shouldSpawnEnemies;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shouldSpawnEnemies = true;
        enableSpawningEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enableSpawningEnemies()
    {
        StartCoroutine(spawnEnemies());
    }

    IEnumerator spawnEnemies()
    {
        while (shouldSpawnEnemies)
        {
            GameObject newEnemy = Instantiate(enemy, transform.position, Quaternion.identity);
            enemyManager.addEnemy(newEnemy);
            yield return new WaitForSeconds(1f);
        }
    }

    public void disableSpawningEnemies()
    {
        shouldSpawnEnemies = false;
    }
}
