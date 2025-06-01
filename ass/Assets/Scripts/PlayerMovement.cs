using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const string Horizontal = "Horizontal";

    [SerializeField] private Transform PlaerSprite;
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _jumpForce = 5f;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float directionX = Input.GetAxis(Horizontal);
        float distance = directionX * _moveSpeed * Time.deltaTime;
        transform.Translate(distance * Vector2.right);
    }
}

