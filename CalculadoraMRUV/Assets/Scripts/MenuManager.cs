using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    void Start() {
     
    }
    
    public void BotonAceleracion()
    {
         SceneManager.LoadScene("Aceleracion");
    }

    public void BotonVertical()
    {
         SceneManager.LoadScene("Vertical");
    }

    public void BotonAlcance()
    {
         SceneManager.LoadScene("Alcance");
    }

    public void BotonEncuentro()
    {
         SceneManager.LoadScene("Encuentro");
    }

    public void BotonMenu()
    {
         SceneManager.LoadScene("Menu");
    }

    public void BotonSalida()
    {
        print("Salimos de la Aplicacion");
        Application.Quit();
    }

   
}
