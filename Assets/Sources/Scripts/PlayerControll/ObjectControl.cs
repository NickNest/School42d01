using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControl : MonoBehaviour, IMovable, IJumpable
{
    [field: SerializeField] public float Speed { get; private set; } = 5;
    [field: SerializeField] public float JumpForce { get; private set; } = 5;

    private Rigidbody2D _rb;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    public void Move(float horizontalSpeed)
    {
        _rb.velocity = new Vector2(Speed * horizontalSpeed / 10, _rb.velocity.y);
    }
    public void Jump()
    {
        _rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
    }
}
