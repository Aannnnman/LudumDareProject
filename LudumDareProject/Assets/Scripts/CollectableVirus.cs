using System;
using UnityEngine;

public class CollectableVirus : MonoBehaviour
{
    public static event Action OnVirusTaked;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            PlayerData player = collision.GetComponent<PlayerData>();

            if (player != null)
            {
                OnVirusTaked?.Invoke();
                Destroy(gameObject);
            }
        }
    }
}
