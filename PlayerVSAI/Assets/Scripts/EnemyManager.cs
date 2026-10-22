using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    public List<GameObject> enemies = new List<GameObject>();
    private Transform player;
    private GameObject enemy;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Transform>();
        enemy = Instantiate(enemyPrefab);
        enemy.GetComponent<WalkerEnemy>().enemyManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject FindClosestEnemy() 
    {
        if (!enemies.Any())
        {
            return null;
        }
        GameObject closestEnemy = null;
        float closestDistance = float.MaxValue;
        foreach(GameObject enemy in enemies)
        {
            float enemyDistance = Vector2.Distance(player.position, enemy.transform.position);
            /*if (closestEnemy == null){
                closestEnemy = enemy;
                closestDistance = enemyDistance;
                continue;
            }*/
            if(closestDistance > enemyDistance)
            {
                closestEnemy = enemy;
                closestDistance = enemyDistance; 
            }
        }
        return closestEnemy;
    }
}
