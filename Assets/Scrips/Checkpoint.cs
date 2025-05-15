using UnityEngine;

public class Checkpoint : MonoBehaviour
{   
    [Header("Componentes (sprite)")]
    public SpriteRenderer sprch;

    [Header("Componentes (imagenes)")]
    public Sprite cpOn;
    public Sprite cpOff;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.CompareTag("Player"))
        {
            CheckpointController.instance.DesactivarCheckPoints();
            sprch.sprite = cpOn;

            AudioManager.instance.CheckPoint();
            CheckpointController.instance.SetpuntoReaparecion(transform.position);
        }
    }

    public void ResetCheckpoint()
    {
        sprch.sprite = cpOff;
    }
}
