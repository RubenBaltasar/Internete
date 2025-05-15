using UnityEngine;

public class CamaraController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    [Header("Componente (Player)")]
    public Transform objetivo;
    


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(objetivo.position.x,transform.position.y,transform.position.z);

        
    }
}
