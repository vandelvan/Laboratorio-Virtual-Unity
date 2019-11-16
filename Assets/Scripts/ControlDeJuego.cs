using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlDeJuego : MonoBehaviour
{
    public Transform sensorA;
    public Transform sensorB;
    public avanceCarro carro;
    public Tiempo cronometro;
    public InputField inputSensor1;
    public InputField inputSensor2;
    public Text cantIncorrectA;
    public Text cantIncorrectB;
    public GameObject panelA;
    public GameObject panelB;
    public GameObject panelVel;
    public Button botonInicio;
    private float m1 = 4;
    private float m2 = 6;
    void Start()
    {
        carro.inicio = false;
        cronometro.inicio = false;
        botonInicio.enabled = false;
        cantIncorrectA.gameObject.SetActive(false);
        cantIncorrectB.gameObject.SetActive(false);
    }
    public void posicion1(string metros){
        m1 = float.Parse(metros);
        if(m1<=1.6f)
            m1 = 1.6f;
        if(m1 > 0 && m1 <= 100){
            cantIncorrectA.gameObject.SetActive(false);
            if(m1 < m2){
                cantIncorrectA.gameObject.SetActive(false);
                sensorA.position = new Vector3(1,0,m1);
                inputSensor2.enabled = true;
                botonInicio.enabled = true;
            }
            else{
                cantIncorrectA.gameObject.SetActive(true);
                cantIncorrectA.text = "Debe ser una distancia menor a la del segundo sensor!";
                inputSensor2.enabled = false;
                botonInicio.enabled = false;
            }
        }
        else{
            cantIncorrectA.gameObject.SetActive(true);
            cantIncorrectA.text = "Debe ser un valor entre 1 y 100m!";
            botonInicio.enabled = false;
        }
    }

    public void posicion2(string metros){
        m2 = float.Parse(metros);
        if(m2 > 0 && m2 <= 100){
            cantIncorrectB.gameObject.SetActive(false);
            if(m1 < m2){
                cantIncorrectB.gameObject.SetActive(false);
                sensorB.position = new Vector3(1,0,m2);
                inputSensor1.enabled = true;
                botonInicio.enabled = true;
            }
            else{
                cantIncorrectB.gameObject.SetActive(true);
                cantIncorrectB.text = "Debe ser una distancia mayor a la del primer sensor!";
                inputSensor1.enabled = false;
                botonInicio.enabled = false;
            }
        }
        else{
            cantIncorrectB.gameObject.SetActive(true);
            cantIncorrectB.text = "Debe ser un valor entre 1 y 100m!";
            botonInicio.enabled = false;
        }
    }
    public void iniciar(){
        cantIncorrectA.gameObject.SetActive(false);
        cantIncorrectB.gameObject.SetActive(false);
        panelA.gameObject.SetActive(false);
        panelB.gameObject.SetActive(false);
        panelVel.gameObject.SetActive(false);
        botonInicio.gameObject.SetActive(false);
        carro.inicio = true;
        cronometro.inicio = true;
    }
    public void setVelocidad(string velocidad){
        float ms = float.Parse(velocidad);
        if(ms > 0){
            botonInicio.enabled = true;
            carro.ms = ms;
            cronometro.ms = ms;
        }
        else{
            botonInicio.enabled = false;
        }
    }
}
