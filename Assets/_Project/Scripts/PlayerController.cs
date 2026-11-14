using TMPro;
using UnityEngine;

public partial class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce= 100;
    [SerializeField] private GameObject restartMenu;
    [SerializeField] private TextMeshProUGUI scoreLabel;
    [SerializeField] private Animator animator;

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
        Time.timeScale = 0;
        restartMenu.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        scoreLabel.text = score.ToString();
    }
}
