using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fly : MonoBehaviour
{
    private Rigidbody2D rb;

    public float jumpForce = 100;

    private int score = 0;

    public TextMeshProUGUI scoreText;

    public SpriteRenderer plane;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        plane = GetComponent<SpriteRenderer>();


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

    void OnTriggerEnter2D(Collider2D col)
    {
        scoreText.text = (++score).ToString("0000");
    }
}
