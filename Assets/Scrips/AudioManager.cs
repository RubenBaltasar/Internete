using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;

    [Header("Sonidos")]
    public AudioSource picaduraSerpiente;
    public AudioSource golpeEnemigo;
    public AudioSource golpeAEnemigo;
    public AudioSource checkpoint;
    private void Awake()
    {
        instance = this;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AudioSerpiente()
    {
        picaduraSerpiente.Play();
    }

    public void GolpeEnemigo()
    {
         golpeEnemigo.Play();   
    }

    public void GolpeAEnemigo()
    {
        golpeAEnemigo.Play();
    }

    public void CheckPoint()
    {
        checkpoint.Play();
    }
}
