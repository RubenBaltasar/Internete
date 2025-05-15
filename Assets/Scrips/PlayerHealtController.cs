using UnityEngine;

public class PlayerHealtController : MonoBehaviour
{
    public static PlayerHealtController instance;

    [Header("Variables")]
    public int vida, vidamMax = 20;
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
        
    }

    public void Damage()
    {
        vida --;
        UIController.instance.UpdateVidaUI();
        if (vida <=0)
        {
           // gameObject.SetActive(false);
           Instantiate(efectoMuerte,PlayerHealtController.instance.transform.position,PlayerHealtController.instance.transform.rotation);
           LevelManager.instance.ReapacicionPlayer();
        }
        
    }
    public void Damage2()
    {
        vida -=2;
        UIController.instance.UpdateVidaUI();
        if (vida <=0)
        {
           // gameObject.SetActive(false);
           Instantiate(efectoMuerte,PlayerHealtController.instance.transform.position,PlayerHealtController.instance.transform.rotation);
           LevelManager.instance.ReapacicionPlayer();
        }
        
    }
    public void Damage3()
    {
        vida -=3;
        UIController.instance.UpdateVidaUI();
        if (vida <=0)
        {
           // gameObject.SetActive(false);
           Instantiate(efectoMuerte,PlayerHealtController.instance.transform.position,PlayerHealtController.instance.transform.rotation);
           LevelManager.instance.ReapacicionPlayer();
        }
        
    }
        public void Damage4()
    {
        vida -=4;
        UIController.instance.UpdateVidaUI();
        if (vida <=0)
        {
           // gameObject.SetActive(false);
           Instantiate(efectoMuerte,PlayerHealtController.instance.transform.position,PlayerHealtController.instance.transform.rotation);
           LevelManager.instance.ReapacicionPlayer();
        }
        
    }

    public void Curar()
    {
       if(vida != vidamMax)
       {
        vida ++;
       } 
       UIController.instance.UpdateVidaUI();
    }

        public void Curar2()
    {
       if(vida != vidamMax)
       {
        if (vida >= 16)
        {
            vida = vidamMax;
        }else
        {
            vida +=4;
        }  
       } 
       UIController.instance.UpdateVidaUI();
    }

        public void Curar4()
    {
       if(vida != vidamMax)
       {
        if (vida >= 12)
        {
            vida = vidamMax;
        }else
        {
            vida +=8;
        }  
       } 
       UIController.instance.UpdateVidaUI();
    }
}
