using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{

private bool pausa = false;
[SerializeField] private GameObject menupausa;
[SerializeField] private GameObject botonsalir;
[SerializeField] private GameObject botoncontinuar;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pausa)
            {
                Pausa();
            }else
            {
                Continuar();
            }
            
        } 
    }
    public void Start()
    {
        menupausa.SetActive(false);
    }

    public void Pausa()
    {  
        Time.timeScale = 0f;
        menupausa.SetActive(true);
    }

    public void Continuar()
    {
        menupausa.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
