using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private const string Horizontal = "Horizontal";

    [SerializeField] private Transform PlaerSprite;
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _jumpForce = 5f;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private LayerMask _groundLayer;
    [SerializeField] private float _groundCheckRadius = 0.1f;

    private Rigidbody2D _rb;
    private bool _isGrounded;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
        CheckGround();

        if (_isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Move()
    {
        float directionX = Input.GetAxis(Horizontal);
        float distance = directionX * _moveSpeed * Time.deltaTime;
        transform.Translate(distance * Vector2.right);
    }

    private void Jump()
    {
        _rb.linearVelocity = new Vector2(_rb.linearVelocity.x, _jumpForce);
    }

    private void CheckGround()
    {
        _isGrounded = Physics2D.OverlapCircle(_groundCheck.position, _groundCheckRadius, _groundLayer);
    }
}


