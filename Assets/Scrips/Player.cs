using UnityEngine;


public class Player : MonoBehaviour
{
    [Header("Componentes")]
    private Rigidbody2D rb;
    public Animator animator;
    private SpriteRenderer sr;

    [Header("Variables")]
    public float velocidad = 4f;
    public float salto = 8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //procesar();
    }

    public void procesar()
    {

        float inputMovimientoh = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(inputMovimientoh * velocidad, rb.linearVelocityY);
        if (Input.GetButtonDown("Jump"))
        {
            if (GroundedScrip.isGrounded)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocityX, salto);
            }

        }

        if (rb.linearVelocityX < 0)
        {
            sr.flipX = true;
        }
        else if (rb.linearVelocityX > 0)
        {
            sr.flipX = false;
        }
        animator.SetFloat("velocidad", Mathf.Abs(rb.linearVelocityX));
        animator.SetBool("isGrounded", GroundedScrip.isGrounded);

    }

    public void clickLeft()
    {
        sr.flipX = true;
        rb.linearVelocity = new Vector2(-1f*velocidad, rb.linearVelocityY);
        animator.SetFloat("velocidad", 1f);
    }

    public void clickRight()
    {
        sr.flipX = false;
        rb.linearVelocity = new Vector2(1f*velocidad, rb.linearVelocityY);
        animator.SetFloat("velocidad", 1f);
    }

    public void releaseLeft()
    {
        rb.linearVelocity = new Vector2(0f, rb.linearVelocityY);
        animator.SetFloat("velocidad", 0f);
    }

    public void releaseRight()
    {
        rb.linearVelocity = new Vector2(0f, rb.linearVelocityY);
        animator.SetFloat("velocidad", 0f);
    }

    public void clickSalto()
    {
        if (GroundedScrip.isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, salto);
        }
            animator.SetBool("isGrounded", GroundedScrip.isGrounded);
    }
}
