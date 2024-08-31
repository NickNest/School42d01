using UnityEngine;

public class ObjectControl : MonoBehaviour, IMovable, IJumpable
{
    [field: SerializeField] public float Speed { get; private set; } = 5;
    [field: SerializeField] public float JumpForce { get; private set; } = 5;

    private BoxCollider2D _boxCollider2D;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

    public void Move(float horizontalSpeed)
    {
        _rb.velocity = new Vector2(Speed * horizontalSpeed / 10, _rb.velocity.y);
    }

    public void Jump()
    {
        if (IsGrounded())
            _rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
    }

    public bool IsGrounded()
    {
        var offset = new Vector3(0, _boxCollider2D.size.y / 2 + 0.01f, 0);
        var size = new Vector3(_boxCollider2D.size.x, 0.005f, 0);

        RaycastHit2D groundRaycastHit2D = 
            Physics2D.BoxCast(
            _boxCollider2D.bounds.center - offset, 
            size, 0f, Vector2.down, 0f);

        return groundRaycastHit2D.collider != null;
    }
}