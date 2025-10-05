using System.Collections;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    [SerializeField] private float _destroyTime;
    [SerializeField] private float _respawnDelay;
    [SerializeField] private AudioSource _audioSource;

    private Vector3 _startPosition;
    private Quaternion _startRotation;

    private void Awake()
    {
        _startPosition = transform.position;
        _startRotation = transform.rotation;
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

        if (_audioSource != null)
            _audioSource.Play();

        gameObject.SetActive(false);

        yield return new WaitForSeconds(_respawnDelay);

        transform.position = _startPosition;
        transform.rotation = _startRotation;
        gameObject.SetActive(true);
    }
}
