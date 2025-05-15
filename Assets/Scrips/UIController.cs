
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public static UIController instance;

    [Header("Componentes (imagenes)")]
    public Image heart1; 
    public Image heart2;
    public Image heart3;
    public Image heart4;
    public Image heart5;
    public Image heart6; 
    public Image heart7;
    public Image heart8;
    public Image heart9;
    public Image heart10;


    [Header("Componentes (corazones)")]
    public Sprite corazonLleno;
    public Sprite corazonMedio;
    public Sprite corazonVacio;

    public TextMeshProUGUI puntos;
   

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateVidaUI()
    {
        switch(PlayerHealtController.instance.vida)
        {
            case 20:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonLleno;
                heart3.sprite = corazonLleno;
                heart4.sprite = corazonLleno;
                heart5.sprite = corazonLleno;
                heart6.sprite = corazonLleno;
                heart7.sprite = corazonLleno;
                heart8.sprite = corazonLleno;
                heart9.sprite = corazonLleno;
                heart10.sprite = corazonLleno;
                break;
            case 19:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonLleno;
                heart3.sprite = corazonLleno;
                heart4.sprite = corazonLleno;
                heart5.sprite = corazonLleno;
                heart6.sprite = corazonLleno;
                heart7.sprite = corazonLleno;
                heart8.sprite = corazonLleno;
                heart9.sprite = corazonLleno;
                heart10.sprite = corazonMedio;
                break;
            case 18:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonLleno;
                heart3.sprite = corazonLleno;
                heart4.sprite = corazonLleno;
                heart5.sprite = corazonLleno;
                heart6.sprite = corazonLleno;
                heart7.sprite = corazonLleno;
                heart8.sprite = corazonLleno;
                heart9.sprite = corazonLleno;
                heart10.sprite = corazonVacio;
                break;
            case 17:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonLleno;
                heart3.sprite = corazonLleno;
                heart4.sprite = corazonLleno;
                heart5.sprite = corazonLleno;
                heart6.sprite = corazonLleno;
                heart7.sprite = corazonLleno;
                heart8.sprite = corazonLleno;
                heart9.sprite = corazonMedio;
                heart10.sprite = corazonVacio;
                break;
            case 16:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonLleno;
                heart3.sprite = corazonLleno;
                heart4.sprite = corazonLleno;
                heart5.sprite = corazonLleno;
                heart6.sprite = corazonLleno;
                heart7.sprite = corazonLleno;
                heart8.sprite = corazonLleno;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
            case 15:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonLleno;
                heart3.sprite = corazonLleno;
                heart4.sprite = corazonLleno;
                heart5.sprite = corazonLleno;
                heart6.sprite = corazonLleno;
                heart7.sprite = corazonLleno;
                heart8.sprite = corazonMedio;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
            case 14:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonLleno;
                heart3.sprite = corazonLleno;
                heart4.sprite = corazonLleno;
                heart5.sprite = corazonLleno;
                heart6.sprite = corazonLleno;
                heart7.sprite = corazonLleno;
                heart8.sprite = corazonVacio;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
            case 13:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonLleno;
                heart3.sprite = corazonLleno;
                heart4.sprite = corazonLleno;
                heart5.sprite = corazonLleno;
                heart6.sprite = corazonLleno;
                heart7.sprite = corazonMedio;
                heart8.sprite = corazonVacio;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
            case 12:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonLleno;
                heart3.sprite = corazonLleno;
                heart4.sprite = corazonLleno;
                heart5.sprite = corazonLleno;
                heart6.sprite = corazonLleno;
                heart7.sprite = corazonVacio;
                heart8.sprite = corazonVacio;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
            case 11:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonLleno;
                heart3.sprite = corazonLleno;
                heart4.sprite = corazonLleno;
                heart5.sprite = corazonLleno;
                heart6.sprite = corazonMedio;
                heart7.sprite = corazonVacio;
                heart8.sprite = corazonVacio;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
            case 10:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonLleno;
                heart3.sprite = corazonLleno;
                heart4.sprite = corazonLleno;
                heart5.sprite = corazonLleno;
                heart6.sprite = corazonVacio;
                heart7.sprite = corazonVacio;
                heart8.sprite = corazonVacio;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
            case 9:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonLleno;
                heart3.sprite = corazonLleno;
                heart4.sprite = corazonLleno;
                heart5.sprite = corazonMedio;
                heart6.sprite = corazonVacio;
                heart7.sprite = corazonVacio;
                heart8.sprite = corazonVacio;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
            case 8:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonLleno;
                heart3.sprite = corazonLleno;
                heart4.sprite = corazonLleno;
                heart5.sprite = corazonVacio;
                heart6.sprite = corazonVacio;
                heart7.sprite = corazonVacio;
                heart8.sprite = corazonVacio;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
            case 7:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonLleno;
                heart3.sprite = corazonLleno;
                heart4.sprite = corazonMedio;
                heart5.sprite = corazonVacio;
                heart6.sprite = corazonVacio;
                heart7.sprite = corazonVacio;
                heart8.sprite = corazonVacio;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
            case 6:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonLleno;
                heart3.sprite = corazonLleno;
                heart4.sprite = corazonVacio;
                heart5.sprite = corazonVacio;
                heart6.sprite = corazonVacio;
                heart7.sprite = corazonVacio;
                heart8.sprite = corazonVacio;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
            case 5:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonLleno;
                heart3.sprite = corazonMedio;
                heart4.sprite = corazonVacio;
                heart5.sprite = corazonVacio;
                heart6.sprite = corazonVacio;
                heart7.sprite = corazonVacio;
                heart8.sprite = corazonVacio;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
            case 4:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonLleno;
                heart3.sprite = corazonVacio;
                heart4.sprite = corazonVacio;
                heart5.sprite = corazonVacio;
                heart6.sprite = corazonVacio;
                heart7.sprite = corazonVacio;
                heart8.sprite = corazonVacio;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
            case 3:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonMedio;
                heart3.sprite = corazonVacio;
                heart4.sprite = corazonVacio;
                heart5.sprite = corazonVacio;
                heart6.sprite = corazonVacio;
                heart7.sprite = corazonVacio;
                heart8.sprite = corazonVacio;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
            case 2:
                heart1.sprite = corazonLleno;
                heart2.sprite = corazonVacio;
                heart3.sprite = corazonVacio;
                heart4.sprite = corazonVacio;
                heart5.sprite = corazonVacio;
                heart6.sprite = corazonVacio;
                heart7.sprite = corazonVacio;
                heart8.sprite = corazonVacio;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
            case 1:
                heart1.sprite = corazonMedio;
                heart2.sprite = corazonVacio;
                heart3.sprite = corazonVacio;
                heart4.sprite = corazonVacio;
                heart5.sprite = corazonVacio;
                heart6.sprite = corazonVacio;
                heart7.sprite = corazonVacio;
                heart8.sprite = corazonVacio;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
            case 0:
                heart1.sprite = corazonVacio;
                heart2.sprite = corazonVacio;
                heart3.sprite = corazonVacio;
                heart4.sprite = corazonVacio;
                heart5.sprite = corazonVacio;
                heart6.sprite = corazonVacio;
                heart7.sprite = corazonVacio;
                heart8.sprite = corazonVacio;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
            default:
                heart1.sprite = corazonVacio;
                heart2.sprite = corazonVacio;
                heart3.sprite = corazonVacio;
                heart4.sprite = corazonVacio;
                heart5.sprite = corazonVacio;
                heart6.sprite = corazonVacio;
                heart7.sprite = corazonVacio;
                heart8.sprite = corazonVacio;
                heart9.sprite = corazonVacio;
                heart10.sprite = corazonVacio;
                break;
        }
    }
}
