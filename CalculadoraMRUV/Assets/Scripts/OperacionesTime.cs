using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class OperacionesTime : MonoBehaviour
{
    public TMP_Text t;
    
    public TMP_InputField vi;
    public TMP_InputField vf;
    public TMP_InputField d;

    public GameObject errorAviso;

    float velIni = 0;
    float velFin;
    float tiempo;
    float distancia;
    public bool calculado = false;

    public void setVelocidadFinal()
    {  
          if(verificadorTipo(vf))
            velFin = float.Parse(vf.text);
    }

 public void setVelocidadInicial()
    {  
         if(verificadorTipo(vi))
           velIni = float.Parse(vi.text);
         
    }

    public void setDistancia()
    {  
         if(verificadorTipo(d))
           distancia = float.Parse(d.text);
    }

   
    private bool verificadorTipo(TMP_InputField t)
    {
        if(!float.TryParse(t.text, out tiempo) || t.text.Equals("")){
           errorAviso.SetActive(true); 
           return false;
        }
     return true;
    }

    public void errorClose()
    {
     errorAviso.SetActive(false);
    }

    public void calcularTiempo()
    {
          if(!float.TryParse(vi.text, out tiempo) ||!float.TryParse(vf.text, out tiempo) || !float.TryParse(d.text, out tiempo)){ 
               errorAviso.SetActive(true); 
          }
          else if(velIni <= 0 && velFin <= 0)
          {
               tiempo = 0;
          }
          else
          {
               tiempo = (2.0f*distancia)/(velIni + velFin);
               t.SetText("Tiempo: "+ tiempo.ToString() + "s");
               calculado = true;
          } 
    }
}
