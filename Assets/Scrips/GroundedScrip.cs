using UnityEngine;

public class GroundedScrip : MonoBehaviour
{

    public static bool isGrounded;


    public void OnTriggerEnter2D(Collider2D collision)
    {   
         if (collision.tag == "Suelo")
        {
            isGrounded = true;
        }
        if (collision.tag == "Enemigo")
        {
            isGrounded = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Suelo")
        {
            isGrounded = false;
        }
        if (collision.tag == "Enemigo")
        {
            isGrounded = false;
        }
    }
}
