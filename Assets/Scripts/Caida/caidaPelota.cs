using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class caidaPelota : MonoBehaviour
{
    public Rigidbody pelota;
    public bool inicio;
    public Tiempo tiempo;
    public Button botonSalir;
    void OnCollisionEnter(Collision objeto){
        if(objeto.collider.name == "Sensor"){
            tiempo.inicio = false;
            tiempo.velocidad();
            botonSalir.gameObject.SetActive(true);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {   if(inicio == true){
            pelota.useGravity = true;
        }
    }

    public void setAltura(float alt){
        pelota.transform.position = new Vector3(pelota.transform.position.x, alt, pelota.transform.position.z);
    }
}
