using UnityEngine;

public class PlayerHorizontalFlip : MonoBehaviour
{
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private GameObject[] _noFlipObjects;

    private bool _isFacingRight;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (_playerData.ReadMoveInput() < 0 && !_isFacingRight || _playerData.ReadMoveInput() > 0 && _isFacingRight)
            SpriteFlip();
    }

    private void SpriteFlip()
    {
        _isFacingRight = !_isFacingRight;
        _spriteRenderer.flipX = _isFacingRight;
    }
}