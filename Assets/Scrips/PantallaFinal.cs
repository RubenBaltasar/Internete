using UnityEngine;
using UnityEngine.SceneManagement;

public class PantallaFinal : MonoBehaviour
{

       void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }  
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
