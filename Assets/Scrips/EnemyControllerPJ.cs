using UnityEngine;
using UnityEngine.Rendering;

public class EnemyControllerPJ : MonoBehaviour
{


    public float movespeed = 0.2f;

    public Transform puntoDerecho;
    public Transform puntoIzquiedo;

    private bool movimientoDerecho;
    private Rigidbody2D rb;
    public SpriteRenderer sr;
    public Animator animator;

    public float tiempoMovimiento;
    public float tiempoEspera;

    private float cuentaMovimiento;
    private float cuentaEspera;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        puntoDerecho.parent = null;
        puntoIzquiedo.parent = null;

        cuentaMovimiento = tiempoMovimiento;
    }

    // Update is called once per frame
    void Update()
    {

        if (cuentaMovimiento > 0)
        {
            animator.SetBool("caminando", true);
            cuentaMovimiento -= Time.deltaTime;
            if (movimientoDerecho)
            {
                rb.linearVelocity = new Vector2(movespeed, rb.linearVelocityY);
                sr.flipX = false;

                if (transform.position.x > puntoDerecho.position.x)
                {
                    movimientoDerecho = false;
                }
            }
            else
            {
                rb.linearVelocity = new Vector2(-movespeed, rb.linearVelocityY);
                sr.flipX = true;

                if (transform.position.x < puntoIzquiedo.position.x)
                {
                    movimientoDerecho = true;
                }
            }
            if(cuentaMovimiento <= 0)
            {
                cuentaEspera = tiempoEspera;
                animator.SetBool("caminando", false);
            }
            
        }else if (cuentaEspera > 0)
        {
            cuentaEspera -= Time.deltaTime;
            rb.linearVelocity = new Vector2(0f, rb.linearVelocityY);
            if(cuentaEspera <= 0)
            {
                cuentaMovimiento = tiempoMovimiento;
            }
            
        }


    }
}
