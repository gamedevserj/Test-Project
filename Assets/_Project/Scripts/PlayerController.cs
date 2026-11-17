using TMPro;
using UnityEngine;

public partial class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce= 100;
    [SerializeField] private GameObject restartMenu;
    [SerializeField] private TextMeshProUGUI scoreLabel;
    [SerializeField] private Animator animator;
    [SerializeField] private Animator animator2;
    [SerializeField] private float minVelocityY = -2;

    private int score;

    private Transform tr;
    private Rigidbody2D rb;

    private void Awake()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var velocityY = rb.linearVelocityY;
        animator.SetFloat("VelocityY", velocityY);


        var clampedVelocity = Mathf.InverseLerp(minVelocityY, jumpForce, velocityY);
        clampedVelocity *= 2;
        clampedVelocity -= 1;

        animator2.SetFloat("Blend", clampedVelocity);
    }

    private void FixedUpdate()
    {
        var velocityY = rb.linearVelocityY;
        if (velocityY < minVelocityY)
        {
            velocityY = minVelocityY;
        }
        rb.linearVelocityY = velocityY;
    }

    public void Move(Vector2 movement)
    {
        //tr.Translate(movement * Time.deltaTime, Space.World);
    }

    public void Jump()
    {
        rb.linearVelocityY = 0;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0;
        restartMenu.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        scoreLabel.text = score.ToString();
    }
}
