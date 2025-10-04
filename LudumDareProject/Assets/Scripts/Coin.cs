using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static event Action OnCoinTaked;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            PlayerData player = collision.GetComponent<PlayerData>();

            if (player != null)
            {
                OnCoinTaked?.Invoke();
                Destroy(gameObject);
            }
        }
    }
}
