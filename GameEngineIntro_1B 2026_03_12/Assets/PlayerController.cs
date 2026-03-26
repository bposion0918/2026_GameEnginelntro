using JetBrains.Rider.Unity.Editor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Vector2 moveInput;
    public float movespeed = 7f;
    public float jumpforce = 7f;
    private Rigidbody2D rb;
    private Animator myAnimator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myAnimator.SetBool("move", false);
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        if (value.isPressed) // 점프 버튼을 누르면
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpforce);
        }
    }

    void Update()
    {
        if (moveInput.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (moveInput.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (moveInput.magnitude > 0)
        {
            myAnimator.SetBool("move", true);
        }
        else
        {
            myAnimator.SetBool("move", false);
        }
        transform.Translate(Vector3.right * movespeed * moveInput.x * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Death")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            SceneManager.LoadScene("PlayScene_" + collision.name);
        }
    }
}


