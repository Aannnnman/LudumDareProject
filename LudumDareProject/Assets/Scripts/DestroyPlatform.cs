using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        {
            PlayerData player = collision.gameObject.GetComponent<PlayerData>();

            if (player != null)
            {
                Destroy(gameObject);
            }
        }
    }
}
