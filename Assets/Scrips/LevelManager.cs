using System.Collections;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    
    public static LevelManager instance;


    [Header("Variables")]
    public float tiemproReaparicion = 2f;

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

    public void ReapacicionPlayer()
    {
        StartCoroutine(ReaparicionCo());
    }

    IEnumerator ReaparicionCo()
    {
        PlayerHealtController.instance.gameObject.SetActive(false);

        yield return new WaitForSeconds(tiemproReaparicion);

        PlayerHealtController.instance.gameObject.SetActive(true);

        PlayerHealtController.instance.vida = PlayerHealtController.instance.vidamMax;

        PlayerHealtController.instance.transform.position = CheckpointController.instance.puntoReaparecion;

        UIController.instance.UpdateVidaUI();
        
    }
}
