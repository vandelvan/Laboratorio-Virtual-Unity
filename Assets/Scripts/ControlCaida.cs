using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ControlCaida : MonoBehaviour
{
    public Transform sensor;
    public caidaPelota pelota;
    public Tiempo cronometro;
    public InputField inputAltura;
    public Text cantIncorrecta;
    public GameObject panelAltura;
    public Button botonInicio;
    public Button botonSalir;
    private float m1 = 4;
    void Start()
    {
        pelota.inicio = false;
        cronometro.inicio = false;
        botonInicio.enabled = false;
        cantIncorrecta.gameObject.SetActive(false);
        Debug.Log(Physics.gravity);
    }
    public void setAltura(string metros){
        m1 = float.Parse(metros);
        if(m1 > 1 && m1 <= 100){
            cantIncorrecta.gameObject.SetActive(false);
            pelota.setAltura(m1);
            inputAltura.enabled = true;
            botonInicio.enabled = true;
        }
        else{
            cantIncorrecta.gameObject.SetActive(true);
            cantIncorrecta.text = "Debe ser un valor entre 1 y 100m!";
            botonInicio.enabled = false;
        }
    }

    public void iniciar(){
        cantIncorrecta.gameObject.SetActive(false);
        panelAltura.gameObject.SetActive(false);
        botonInicio.gameObject.SetActive(false);
        botonSalir.gameObject.SetActive(false);
        pelota.inicio = true;
        cronometro.inicio = true;
    }
    public void salir(){
        SceneManager.LoadScene("Menu");
    }
}
