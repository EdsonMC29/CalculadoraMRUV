using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonControl : MonoBehaviour
{
    public GameObject opcion1;
    public GameObject opcion2;
    public GameObject opcion3;
    public GameObject opcion4;
    public GameObject opcion5;
    
    public void botonOpcion1()
     {
          opcion2.SetActive(false);
          opcion3.SetActive(false);
          opcion4.SetActive(false);
          opcion5.SetActive(false);
          opcion1.SetActive(true);
     }

     public void botonOpcion2()
     {
          opcion1.SetActive(false);
          opcion3.SetActive(false);
          opcion4.SetActive(false);
          opcion5.SetActive(false);
          opcion2.SetActive(true);
     }

     public void botonOpcion3()
     {
          opcion2.SetActive(false);
          opcion1.SetActive(false);
          opcion4.SetActive(false);
          opcion5.SetActive(false);
          opcion3.SetActive(true);
     }

     public void botonOpcion4()
     {
          opcion1.SetActive(false);
          opcion3.SetActive(false);
          opcion2.SetActive(false);
          opcion5.SetActive(false);
          opcion4.SetActive(true);
     }

      public void botonOpcion5()
     {
          opcion1.SetActive(false);
          opcion3.SetActive(false);
          opcion2.SetActive(false);
          opcion4.SetActive(false);
          opcion5.SetActive(true);
     }
}
