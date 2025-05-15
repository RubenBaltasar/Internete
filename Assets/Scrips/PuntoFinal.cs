using UnityEngine;
using UnityEngine.SceneManagement;

public class PuntoFinal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            SceneManager.LoadScene("Final");
        }
    }
}
