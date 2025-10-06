using System.Collections;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    [SerializeField] private float _destroyTime;
    [SerializeField] private float _respawnDelay;
    [SerializeField] private AudioSource _audioSource;

    private SpriteRenderer _spriteRenderer;
    private Collider2D _collider;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _collider = GetComponent<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        {
            PlayerData player = collision.gameObject.GetComponent<PlayerData>();

            if (player != null)
            {
                StartCoroutine(HandleDestruction());
            }
        }
    }

    private IEnumerator HandleDestruction()
    {
        yield return new WaitForSeconds(_destroyTime);
        _audioSource.Play();
        _collider.enabled = false;
        _spriteRenderer.enabled = false;

        yield return new WaitForSeconds(_respawnDelay);
        _collider.enabled = true;
        _spriteRenderer.enabled = true;
    }
}
