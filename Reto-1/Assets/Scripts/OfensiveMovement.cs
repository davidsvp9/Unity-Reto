using UnityEngine;
public class ObstaculoPatrulla : MonoBehaviour
{
    [SerializeField] private float speed = 8f;
    [SerializeField] private float minY = -3.4f;
    [SerializeField] private float maxY = 3.4f;
    private Rigidbody2D rb;
    private int direction = 1;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (rb.position.y >= maxY)
        {
            direction = -1;
        }
        else if (rb.position.y <= minY)
        {
            direction = 1;
        }
        rb.linearVelocity = new Vector2(0f, direction * speed);
    }
}