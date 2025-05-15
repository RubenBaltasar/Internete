using UnityEngine;

public class EnemiHealtController : MonoBehaviour
{

    public static EnemiHealtController instance;
    public GameObject objetoPadre;

    public GameObject efectomuerte;
    public GameObject objetoDrop;

    [Header("Variables")]
    [Range(0, 100)] public float porcentageDrop;
    public int vida = 1;

    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            objetoPadre = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Damage()
    {
        AudioManager.instance.GolpeAEnemigo();
        Debug.Log("a");
        vida--;

        if (vida <= 0)
        {
            objetoPadre.SetActive(false);
            //gameObject.SetActive(false);
            Instantiate(efectomuerte, objetoPadre.transform.position, objetoPadre.transform.rotation);
            float dropSelec = Random.Range(0, 100f);

            if (dropSelec <= porcentageDrop)
            {
                Instantiate(objetoDrop, objetoPadre.transform.position, objetoPadre.transform.rotation);
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Hurtbox")
        {
            
            Damage();
        }
    }
}
