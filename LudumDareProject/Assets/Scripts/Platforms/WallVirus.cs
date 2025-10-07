using UnityEngine;

public class WallVirus : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private Transform _player;

    private void OnEnable()
    {
        DestroyObjectOnPlayerCollision.OnVirusDestroy += OnVirusTaking;
    }

    private void OnDisable()
    {
        DestroyObjectOnPlayerCollision.OnVirusDestroy -= OnVirusTaking;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _player.position, _moveSpeed * Time.deltaTime);
    }

    private void OnVirusTaking()
    {
        _player = FindAnyObjectByType<PlayerData>().GetComponent<Transform>();
    }
}
