using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avanceCarro : MonoBehaviour
{
    public float ms = 50;
    public Rigidbody carro;
    void OnCollisionEnter(Collision objeto){
        if(objeto.collider.name == "Pared"){
            ms *= -1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        carro.velocity = new Vector3(0,0,ms * Time.deltaTime);
        // Debug.Log(carro.velocity);
    }
}
