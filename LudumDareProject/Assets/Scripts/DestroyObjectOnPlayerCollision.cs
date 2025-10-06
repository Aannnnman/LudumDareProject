using System;
using UnityEngine;

public class DestroyObjectOnPlayerCollision : MonoBehaviour
{
    public static event Action OnVirusDestroy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            PlayerData player = collision.GetComponent<PlayerData>();

            if (player != null)
            {
                OnVirusDestroy?.Invoke();
                Destroy(gameObject);
            }
        }
    }
}
