using System;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public Boolean serpienteVerde;
    public Boolean serpienteRoja;
    public Boolean serpienteAzul;
    public Boolean serpienteBlanca;
    public Boolean enemigoVerde;
    public Boolean enemigoNaranja;
    public Boolean enemigoRojo; 
    public Boolean enemigoMorado;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            if(serpienteVerde)
            {
                AudioManager.instance.AudioSerpiente();
                PlayerHealtController.instance.Damage();
            }
            if(serpienteAzul)
            {
                AudioManager.instance.AudioSerpiente();
                PlayerHealtController.instance.Damage3();
            }
            if(serpienteRoja)
            {
                AudioManager.instance.AudioSerpiente();
                PlayerHealtController.instance.Damage2();
            }
            if(serpienteBlanca)
            {
                AudioManager.instance.AudioSerpiente();
                PlayerHealtController.instance.Damage4();
            }
            if(enemigoVerde)
            {
                AudioManager.instance.GolpeAEnemigo();
                PlayerHealtController.instance.Damage();
            }
            if(enemigoRojo)
            {
                AudioManager.instance.GolpeAEnemigo();
                PlayerHealtController.instance.Damage2();
            }
            if(enemigoNaranja)
            {
                AudioManager.instance.GolpeAEnemigo();
                PlayerHealtController.instance.Damage3();
            }
            if(enemigoMorado)
            {
                AudioManager.instance.GolpeAEnemigo();
                PlayerHealtController.instance.Damage4();
            }
            
        }
        
    }
}
