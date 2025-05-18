using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
      private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void Controles()
    {
        SceneManager.LoadScene("Controles");
    }

    public void LVL1()
    {
        SceneManager.LoadScene("LVL1");
    }
  
    public void SALIR()
    {
        Application.Quit();
    }
}
