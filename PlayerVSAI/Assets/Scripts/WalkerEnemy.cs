using Unity.VisualScripting;
using UnityEngine;

public class WalkerEnemy : BaseEnemy
{
    private Transform target;
    private Transform transform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Start();
        target = GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Transform>();
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (target != null)transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }
}
