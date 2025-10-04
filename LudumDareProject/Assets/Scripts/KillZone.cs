using UnityEngine;

public class KillZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null) 
        { 
            PlayerData player = collision.gameObject.GetComponent<PlayerData>();
            
            if (player != null)
            {
                Destroy(player.gameObject);
            }
        }
    }
}