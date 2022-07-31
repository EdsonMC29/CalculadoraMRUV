using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OperacionesAce : MonoBehaviour
{
    
    public TMP_Text a;
    
    public TMP_InputField vi;
    public TMP_InputField vf;
    public TMP_InputField t;

    public GameObject errorAviso;

    float velIni;
    float velFin;
    float tiempo;
    float aceleracion;

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

    public void setTiempo()
    {  
         if(verificadorTipo(t))
           tiempo = float.Parse(t.text);
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

    public void calcularAceleracion()
    {
          if(!float.TryParse(vi.text, out tiempo) ||!float.TryParse(vf.text, out tiempo) || !float.TryParse(t.text, out tiempo)){ 
               errorAviso.SetActive(true); 
          }
          else if(tiempo <= 0)
          {
               aceleracion = 0;
          }
          else
          {
               aceleracion = (velFin - velIni)/tiempo;
               a.SetText("Aceleracion: "+ aceleracion.ToString());
          } 
    }
}
