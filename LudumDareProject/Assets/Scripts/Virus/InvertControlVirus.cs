using System.Collections;
using UnityEngine;

public class InvertControlVirus : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private PlayerData _playerData;

    private void Start()
    {
        _playerData = FindFirstObjectByType<PlayerData>();
        StartCoroutine(_playerData.InvertControlLoop(_audioSource));
    }
}
