using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _whatToFollow;

    private void Awake()
    {
        if (_whatToFollow == null)
        {
            PlayerData player = FindAnyObjectByType<PlayerData>();

            if (player.transform != null)
                _whatToFollow = player.transform;
            else
                Debug.Log("WhatToFollowObjectEqualsNull");
        }
    }

    private void Update()
    {
        if (_whatToFollow != null)
            transform.position = new Vector3(_whatToFollow.position.x, _whatToFollow.position.y, -1f);
    }
}
