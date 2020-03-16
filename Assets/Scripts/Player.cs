using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static Player Instance;
    float runSpeed,jumpSpeed, moveX;
    public int lives, coins;
    bool isGrounded = true;
    Rigidbody2D rb;
    public Transform Checkpoint;
    public Transform Sprite;

    private void Awake()
    {
        Instance = this;
        lives = SceneLoaderScript.Instance.PlayerData.Lives;
        coins = SceneLoaderScript.Instance.PlayerData.Coins;
    }


    // Start is called before the first frame update
    void Start()
    {
        runSpeed = 5;
        jumpSpeed = 440;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * runSpeed, rb.velocity.y);
        if (moveX > 0)
        {
            Sprite.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (moveX < 0)
        {
            Sprite.localScale = new Vector3(1f, 1f, 1f);
        }
        //Jumping, player will able to jump after touching the ground
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(transform.up * jumpSpeed);
            isGrounded = false;
        }
        
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ground"  || col.gameObject.tag == "GameController" || col.gameObject.tag == "Help")
        {
            if (col.relativeVelocity.y > 0)
                isGrounded = true;
        }

    }

    public void Die()
    {
        lives--;
        if (lives <= 0)
        {
            SceneManager.LoadScene("World");
            print("Game Over");
        }
        else
        {
            transform.position = Checkpoint.position;
        }
    }

    public void OnDestroy()
    {
        SceneLoaderScript.Instance.PlayerData.Lives = lives;
        SceneLoaderScript.Instance.PlayerData.Coins = coins;
    }
}

