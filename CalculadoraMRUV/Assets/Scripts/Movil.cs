using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Movil : MonoBehaviour
{
    Rigidbody rb;
    public OperacionesVi vi;
    public TMP_Text viSolucion;
    float t = 0;
    float v = 0;
    float d = 0;
  
    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        rb= GetComponent<Rigidbody>();
        //rb.AddForce(vi.velIni,0,0, ForceMode.Impulse);
    }
    void Update(){
        
        if(vi.aceleracion >0){
            if(vi.calculado == true && v <= vi.velFin && t <= vi.tiempo && d <=700){        
                    print(v);
                    viSolucion.SetText("Velocidad: "+ (v).ToString("f0"));
                    rb.transform.position = new Vector3(-78 + d , -17.0f, 90.0f);
                    v += 0.1f;
                    t+= Time.deltaTime;
                    d= (v+vi.velFin)*t*4;
                    
            }
                
        }
        else if(vi.calculado == true && vi.velIni >= vi.velFin && t <= vi.tiempo && d <vi.velIni){
                    
                print(vi.velIni);
                    viSolucion.SetText("Velocidad: "+ (vi.velIni).ToString("f0") + "m/s²");
                    rb.transform.position = new Vector3(-78 + d , -17.0f, 90.0f);
                    vi.velIni = vi.velIni - 0.1f;
                    t+= Time.deltaTime;
                    //d = (vi.velIni + vi.velFin)*t*30;
                    d= vi.velIni*t+ vi.aceleracion*t*t*2.5f;
                    
            }         
    }
}


