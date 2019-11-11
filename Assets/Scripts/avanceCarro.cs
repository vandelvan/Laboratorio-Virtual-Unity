using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avanceCarro : MonoBehaviour
{
    public float ms = 50;
    public Rigidbody carro;
    public bool inicio;
    void OnCollisionEnter(Collision objeto){
        if(objeto.collider.name == "Pared"){
            ms *= -1;
            carro.transform.Rotate(0, 180, 0, Space.Self);
        }
    }
    // Update is called once per frame
    void Update()
    {   if(inicio == true){
        carro.velocity = new Vector3(0,0,ms * Time.deltaTime);
        }
    }
}
