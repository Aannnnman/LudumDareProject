using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Collider2D _collider;

    [Header("MoveSettings")]
    [SerializeField] private float _moveSpeed;
    [SerializeField] private AudioSource _moveSound;

    [Header("JumpSettings")]
    [SerializeField] private AudioSource _jumpSound;
    [SerializeField] private AudioSource _jumpLandingSound;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private Vector2 _groundCheckSize;
    [SerializeField] private LayerMask _whatIsGround;

    public Animator Animator => _animator;
    public Rigidbody2D Rigidbody => _rigidbody;
    public Collider2D Collider => _collider;
    public float MoveSpeed => _moveSpeed;
    public float JumpForce => _jumpForce;
    public AudioSource MoveSound => _moveSound;
    public AudioSource JumpSound => _jumpSound;
    public AudioSource JumpLandingSound => _jumpLandingSound;

    public float ReadMoveInput() => Input.GetAxisRaw("Horizontal");

    public bool ReadJumpInput() => Input.GetKey(KeyCode.Space);

    public bool ReadJumpInputUp() => Input.GetKeyUp(KeyCode.Space);

    public bool IsGrounded() => Physics2D.OverlapBox(_groundCheck.position, _groundCheckSize, 0f, _whatIsGround);

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(_groundCheck.position, _groundCheckSize);
    }

    private void Awake()
    {
        //_moveSound.volume = MusicVolumeControl.GetSoundVolume();
        //_jumpSound.volume = MusicVolumeControl.GetSoundVolume();
        //_jumpLandingSound.volume = MusicVolumeControl.GetSoundVolume();
    }
}