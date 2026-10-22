using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    private int health;
    [SerializeField] protected int maxHealth = 100;
    [SerializeField] protected float moveSpeed = 5f;
    [SerializeField] protected int ContactDamage = 10;
    public EnemyManager enemyManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected void Start()
    {
        enemyManager.enemies.Add(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        print(health);
    }
}
