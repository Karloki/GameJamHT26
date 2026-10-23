using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    private int health;
    [SerializeField] protected int maxHealth = 100;
    [SerializeField] protected float moveSpeed = 5f;
    [SerializeField] protected int ContactDamage = 10;
    public EnemyManager enemyManager;
    [SerializeField] protected GameObject xppickup;



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

        if (health <= 0)
        {
            die();
        }
    }

    private void die()
    {
        Instantiate(xppickup, transform.position, Quaternion.identity);
        if(health <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
