using UnityEngine;
using UnityEngine.Rendering;

public class PlayerHealtController : MonoBehaviour
{
    public static PlayerHealtController instance;

    [Header("Variables")]
    public int vida, vidamMax = 20;
    public float tiempoinvencible;
    private float conteodeinvencivilidad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private SpriteRenderer spr;
    public GameObject efectoMuerte;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        vida = vidamMax;
        spr = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (conteodeinvencivilidad > 0)
        {
            conteodeinvencivilidad -= Time.deltaTime;

            if (conteodeinvencivilidad <= 0)
            {
                spr.color = new Color(spr.color.r, spr.color.g, spr.color.b, 1f);
            }
        }
         
    }

    public void Damage()
    {
        if (conteodeinvencivilidad <= 0)
        {
            vida--;
            
            UIController.instance.UpdateVidaUI();
            if (vida <= 0)
            {
                // gameObject.SetActive(false);
                Instantiate(efectoMuerte, PlayerHealtController.instance.transform.position, PlayerHealtController.instance.transform.rotation);
                LevelManager.instance.ReapacicionPlayer();
            }
            else
            { 
                transparencia();
            }
        }

    }
    public void Damage2()
    {
        if (conteodeinvencivilidad <= 0)
        {
            vida-=2;
            
            UIController.instance.UpdateVidaUI();
            if (vida <= 0)
            {
                // gameObject.SetActive(false);
                Instantiate(efectoMuerte, PlayerHealtController.instance.transform.position, PlayerHealtController.instance.transform.rotation);
                LevelManager.instance.ReapacicionPlayer();
            }
            else
            { 
                transparencia();
            }
        }

    }
    public void Damage3()
    {
        if (conteodeinvencivilidad <= 0)
        {
            vida-=3;
            
            UIController.instance.UpdateVidaUI();
            if (vida <= 0)
            {
                // gameObject.SetActive(false);
                Instantiate(efectoMuerte, PlayerHealtController.instance.transform.position, PlayerHealtController.instance.transform.rotation);
                LevelManager.instance.ReapacicionPlayer();
            }
            else
            { 
                transparencia();
            }
        }
    }
    public void Damage4()
    { if (conteodeinvencivilidad <= 0)
        {
            vida-=4;
            
            UIController.instance.UpdateVidaUI();
            if (vida <= 0)
            {
                // gameObject.SetActive(false);
                Instantiate(efectoMuerte, PlayerHealtController.instance.transform.position, PlayerHealtController.instance.transform.rotation);
                LevelManager.instance.ReapacicionPlayer();
            }
            else
            { 
                transparencia();
            }
        }

    }

    public void Curar()
    {
        if (vida != vidamMax)
        {
            vida++;
        }
        UIController.instance.UpdateVidaUI();
    }

    public void Curar2()
    {
        if (vida != vidamMax)
        {
            if (vida >= 16)
            {
                vida = vidamMax;
            }
            else
            {
                vida += 4;
            }
        }
        UIController.instance.UpdateVidaUI();
    }

    public void Curar4()
    {
        if (vida != vidamMax)
        {
            if (vida >= 12)
            {
                vida = vidamMax;
            }
            else
            {
                vida += 8;
            }
        }
        UIController.instance.UpdateVidaUI();
    }

    public void transparencia()
    {
        conteodeinvencivilidad = tiempoinvencible;
        spr.color = new Color(spr.color.r, spr.color.g, spr.color.b, 0.5f);
    }
}
