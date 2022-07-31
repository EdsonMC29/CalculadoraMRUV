using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OperacionVf : MonoBehaviour
{
    public TMP_Text vf;
    
    public TMP_InputField vi;
    public TMP_InputField t;
    public TMP_InputField a;

    public GameObject errorAviso;

    float velIni;
    float velFin;
    float tiempo;
    float aceleracion;

    public void setVelocidadInicial()
    {  
          if(verificadorTipo(vi))
            velIni = float.Parse(vi.text);
    }

    public void setTiempo()
    {  
         if(verificadorTipo(t))
           tiempo = float.Parse(t.text);
    }

    public void setAceleracion()
    {  
         if(verificadorTipo(a))
           aceleracion = float.Parse(a.text);
         
    }

    private bool verificadorTipo(TMP_InputField x)
    {
        if(!float.TryParse(x.text, out velIni) || x.text.Equals("")){
           errorAviso.SetActive(true); 
           return false;
        }
     return true;
    }

    public void errorClose()
    {
     errorAviso.SetActive(false);
    }

    public void calcularVelocidadFinal()
    {
          if(!float.TryParse(t.text, out velIni) ||!float.TryParse(a.text, out velIni) || !float.TryParse(vi.text, out velIni)){ 
               errorAviso.SetActive(true); 
          }
          else
          {
               velFin = velIni + aceleracion * tiempo;
               if(velFin < 0)
                    velFin = 0;
               vf.SetText("La Velocidad Final es: "+ velFin.ToString());
          }
     
    }
}
