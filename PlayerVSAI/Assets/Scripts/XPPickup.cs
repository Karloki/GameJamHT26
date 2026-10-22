using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class XPPickup : MonoBehaviour
{
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            print("Player touched XPPickup");
            
            Player player = other.GetComponent<Player>();

            if (player != null)
            {
                player.addXP();
            }
            

            Destroy(gameObject);
        }
    }
}
