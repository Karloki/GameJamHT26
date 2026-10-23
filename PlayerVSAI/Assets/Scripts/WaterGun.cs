using System.Collections;
using UnityEngine;

public class WaterGun : MonoBehaviour
{
    [SerializeField] private GameObject target = null;
    [SerializeField] private EnemyManager enemyManager;
    [SerializeField] private WaterBullet waterBullet;
    [SerializeField] private float fireRate = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    IEnumerator Start()
    {
        yield return StartCoroutine(WaitAndShoot(fireRate));
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Fire()
    {
        if (target == null)
        {
            if (enemyManager.FindClosestEnemy() != null)
            {
target = enemyManager.FindClosestEnemy();
            return;
            }
            
        }
        WaterBullet bullet = Instantiate(waterBullet, transform);
        bullet.target = target;
        bullet.transform.SetParent(null);
    }

    private IEnumerator WaitAndShoot(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            Fire();
        }
    }
}
