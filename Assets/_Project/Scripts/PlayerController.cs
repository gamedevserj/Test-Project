using UnityEngine;

public partial class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce= 100;
    private Transform tr;
    private Rigidbody2D rb;

    private void Awake()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 movement)
    {
        //tr.Translate(movement * Time.deltaTime, Space.World);
    }

    public void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
