using System;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public static event Action OnDeath;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            PlayerData player = collision.GetComponent<PlayerData>();

            if (player != null)
            {
                OnDeath?.Invoke();
                Destroy(player.gameObject);
            }
        }
    }
}
