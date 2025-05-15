using UnityEngine;

public class Pickup : MonoBehaviour
{
    [Header("Variables")]
    public bool energiaVerde;
    public bool energiaRoja;
    public bool energiaAzul;

    private bool recolectado;


    public GameObject efecto;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(PlayerHealtController.instance.vida != PlayerHealtController.instance.vidamMax)
            {
                if (energiaRoja)
                {
                    Instantiate(efecto,transform.position,transform.rotation);
                    PlayerHealtController.instance.Curar2();
                }
                if (energiaVerde)
                {
                    Instantiate(efecto,transform.position,transform.rotation);
                    PlayerHealtController.instance.Curar();
                }
                if (energiaAzul)
                {
                    Instantiate(efecto,transform.position,transform.rotation);
                    PlayerHealtController.instance.Curar4();
                }
               recolectado = true;
               Destroy(gameObject); 
            }
        }
    }
}
