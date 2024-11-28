using UnityEngine;

public class Trap : MonoBehaviour
{
    public int damagePerTick = 10; 
    public float damageTickRate = 2f; 
    private float lastDamageTime;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Time.time >= lastDamageTime + damageTickRate)
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damagePerTick);
                lastDamageTime = Time.time; 
            }
        }
    }
}

