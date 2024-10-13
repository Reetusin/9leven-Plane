using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fly : MonoBehaviour
{
    public ScoreManager scoreManager;

    private Rigidbody2D rb;

    public float jumpForce = 100;

    private int score = 0;

    public TextMeshProUGUI scoreText;

    public SpriteRenderer plane;

    public AudioClip successSound;

    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        plane = GetComponent<SpriteRenderer>();

        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            if (rb.velocity.y < 0)
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }

        if(rb.velocity.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 30);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, -30);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        scoreText.text = (++score).ToString("0000");
        audioSource.PlayOneShot(successSound);

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        scoreManager.ShowScoreBoard(score);
        gameObject.SetActive(false);


    }
}
