using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class OperacionesDis : MonoBehaviour
{
    public TMP_Text d;
    
    public TMP_InputField vi;
    public TMP_InputField t;
    public TMP_InputField a;

    public GameObject errorAviso;

    double velIni;
    double distancia;
    double tiempo;
    double aceleracion;
    public bool calculado = false;

    public void setVelocidadInicial()
    {  
          if(verificadorTipo(vi))
            velIni = double.Parse(vi.text);
            else 
               velIni = 0;
    }

    public void setTiempo()
    {  
         if(verificadorTipo(t))
           tiempo = double.Parse(t.text);
    }

    public void setAceleracion()
    {  
         if(verificadorTipo(a))
           aceleracion = double.Parse(a.text);
         
    }

    private bool verificadorTipo(TMP_InputField x)
    {
        if(!double.TryParse(x.text, out velIni) || x.text.Equals("")){
           errorAviso.SetActive(true); 
           return false;
        }
     return true;
    }

    public void errorClose()
    {
     errorAviso.SetActive(false);
    }

    public void calcularDistancia()
    {
          if(!double.TryParse(t.text, out velIni) ||!double.TryParse(a.text, out velIni) || !double.TryParse(vi.text, out velIni)){ 
               errorAviso.SetActive(true); 
          }
          else
          {
               distancia = velIni*tiempo + 0.5*aceleracion * Math.Pow(tiempo, 2);
               if(distancia < 0)
                    distancia =0;
               d.SetText("Distancia: "+ distancia.ToString() + "m");
               calculado = true;
          }
     
    }
}
