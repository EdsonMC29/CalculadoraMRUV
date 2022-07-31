using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Operaciones : MonoBehaviour
{
    public TMP_Text vi;
    public TMP_InputField vf;
    public TMP_InputField t;
    public TMP_InputField a;

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

    private bool verificadorTipo(TMP_InputField t)
    {
        if(!float.TryParse(t.text, out velIni) || t.text.Equals("")){
           errorAviso.SetActive(true); 
           return false;
        }
     return true;
    }

    public void errorClose()
    {
     errorAviso.SetActive(false);
    }

    public void calcularVelocidadInicial()
    {
          if(!float.TryParse(t.text, out velIni) || !float.TryParse(a.text, out velIni) || !float.TryParse(vf.text, out velIni)){ 
               errorAviso.SetActive(true); 
          }
          else
          {
               velIni = velFin - aceleracion * tiempo;
               if(velIni < 0)
                    velIni =0;
               vi.SetText("La Velocidad inicial es: "+ velIni.ToString());
          }
     
    }

  
}    
