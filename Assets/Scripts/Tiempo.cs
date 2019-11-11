using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{
    public Text tiempo;
    public float cronometro;
    public bool inicio;
    void Update()
    {
        if(inicio == true){
            cronometro += Time.deltaTime;
            int minutos = Mathf.FloorToInt(cronometro/60F);
            int segundos = Mathf.FloorToInt(cronometro - minutos * 60);
            int milisegundos = Mathf.FloorToInt((cronometro-segundos)*1000);
            string texto = string.Format("{0:00}:{1:00}:{2:00}",minutos,segundos,milisegundos);
            tiempo.text = texto;
        }
    }
}
