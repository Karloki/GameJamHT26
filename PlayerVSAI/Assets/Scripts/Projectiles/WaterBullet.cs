using System.Data;
using Unity.VisualScripting;
using UnityEngine;

public class WaterBullet : MonoBehaviour
{
    public GameObject target;
    private int damage = 5;
    [SerializeField] private float moveSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        print("hit");
        if (other.gameObject.CompareTag("Enemy")){
            other.gameObject.GetComponent<BaseEnemy>().TakeDamage(damage);
            Destroy(this);

        }
    }
}
