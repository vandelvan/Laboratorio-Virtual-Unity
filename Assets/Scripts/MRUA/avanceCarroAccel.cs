using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class avanceCarroAccel : MonoBehaviour
{
    public float ms = 50;
    public Rigidbody carro;
    public bool inicio;
    public Tiempo tiempo;
    public Button botonSalir;
    void OnCollisionEnter(Collision objeto){
        if(objeto.collider.name == "Pared"){
            ms = 0;
            carro.transform.Rotate(0, 180, 0, Space.Self);
            tiempo.inicio = false;
            tiempo.distanciaTotalAccel();
            botonSalir.gameObject.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider objeto){
        if(objeto.name == "sensorA"){
            tiempo.tiempoSensorAccel1();
        }
        else if(objeto.name == "sensorB"){
            tiempo.tiempoSensorAccel2();
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {   if(inicio == true){
            int minutos = Mathf.FloorToInt(tiempo.cronometro/60F);
            int segundos = Mathf.FloorToInt(tiempo.cronometro - minutos * 60);
            carro.AddForce(0,0,ms * (segundos+1));
        }
    }
}
