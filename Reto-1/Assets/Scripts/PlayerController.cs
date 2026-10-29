using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
[SerializeField] private float speed = 4f;
private Rigidbody2D rb;
private Vector2 moveInput;
private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
private void FixedUpdate()
    {
        rb.linearVelocity = moveInput * speed;
    }
}
