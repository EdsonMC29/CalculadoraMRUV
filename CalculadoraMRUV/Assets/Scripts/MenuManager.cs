using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    void Start() {
     
    }

    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
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

    public void BotonSalida()
    {
        print("Salimos de la Aplicacion");
        //Aplicacion.Quit();
    }

   
}
