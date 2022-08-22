using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    Rigidbody rb;
    public int fuerzaVertical;
    public OperacionVf v;
    float value;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        //rb.transform.position = new Vector3(1.2f , 10.3f, 17.4f);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.transform.position = new Vector3(1.2f , 10.3f, 17.4f);
        if(v.calculado ==true){
             rb.transform.position = new Vector3(1.2f , 10.3f, 17.4f);
             rb.AddForce(0,fuerzaVertical,0, ForceMode.Impulse);
             v.calculado = false;
        }
    }
}
