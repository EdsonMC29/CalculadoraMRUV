using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movil : MonoBehaviour
{
    private float velocidadInicial;
    private float velocidadFinal;
    private float aceleracion;

    //Setters
    public void setVelocidadInicial( float vi){
        velocidadInicial = vi;
    }
    public void setVelocidadFinal(float vf){
        velocidadInicial = vf;
    }
    public void setAceleracion(float a){
        velocidadInicial = a;
    }
    //Getters
    public float getVelocidadInicial(){
        return velocidadInicial;
    }
    public float getVelocidadFinal(){
        return velocidadFinal;
    }
    public float getAceleracion(){
        return aceleracion;
    }
   
}
