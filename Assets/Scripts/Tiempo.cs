﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{
    public Text tiempo;
    public Text tiempo1;
    public Text tiempo2;
    public Text distancia;
    public Text distancia1;
    public Text distancia2;
    public Text tVelocidad;
    public Text tVelocidad1;
    public Text tVelocidad2;
    public float ms;
    public float cronometro;
    public bool inicio;
    private bool t1;
    private float t2;
    private float x1;
    private float x2;
    private float v1;
    private float v2;
    void FixedUpdate()
    {
        if(inicio == true){
            cronometro += Time.deltaTime;
            int minutos = Mathf.FloorToInt(cronometro/60F);
            int segundos = Mathf.FloorToInt(cronometro - minutos * 60);
            int milisegundos = Mathf.FloorToInt((cronometro-segundos)*1000);
            string texto = string.Format("{0:00}:{1:00}:{2:00}",minutos,segundos,milisegundos);
            tiempo.text = texto;
            if(t1){
                t2 += Time.deltaTime;
            }
        }
    }
    public void tiempoSensor1(){
        int minutos = Mathf.FloorToInt(cronometro/60F);
        int segundos = Mathf.FloorToInt(cronometro - minutos * 60);
        int milisegundos = Mathf.FloorToInt((cronometro-segundos)*1000);
        string texto = string.Format("{0:00}:{1:00}:{2:00}",minutos,segundos,milisegundos);
        tiempo1.text = texto;
        x1 = ((ms * cronometro) - 1.6f);
        t1 = true;
        distancia1.text = "x1 = " + x1.ToString() + "m";
    }
    public void tiempoSensor2(){
        int minutos = Mathf.FloorToInt(t2/60F);
        int segundos = Mathf.FloorToInt(t2 - minutos * 60);
        int milisegundos = Mathf.FloorToInt((t2-segundos)*1000);
        string texto = string.Format("{0:00}:{1:00}:{2:00}",minutos,segundos,milisegundos);
        tiempo2.text = texto;
        x2 = x1+((ms * t2) - 1.6f);
        distancia2.text = "x2 = " + x2.ToString() + "m";
    }

    public void distanciaTotal(){
        distancia.text = "x = " + ((ms * cronometro) - 1.6f).ToString() + "m";
    }

    /*FUNCIONES CAIDA LIBRE*/
    public void velocidad(){
        distancia.text = "Vf = " + ((9.8f * cronometro)).ToString() + "m/s";
    }

    /*FUNCIONES M.R.U.A.*/
    public void tiempoSensorAccel1(){
        int minutos = Mathf.FloorToInt(cronometro/60F);
        int segundos = Mathf.FloorToInt(cronometro - minutos * 60);
        int milisegundos = Mathf.FloorToInt((cronometro-segundos)*1000);
        string texto = string.Format("{0:00}:{1:00}:{2:00}",minutos,segundos,milisegundos);
        tiempo1.text = texto;
        v1 = ((ms * cronometro)); //velocidad = v inicial + aceleracion * tiempo
        x1 = ((0.5f * ms * Mathf.Pow(cronometro, 2)) - 1.6f); //X = x inicial + vinicial*tiempo + 1/2*aceleracion*tiempo cuadrado
        t1 = true;
        distancia1.text = "x1 = " + x1.ToString() + "m";
        tVelocidad1.text = "v1 = " + v1.ToString() + "m/s";
    }
    public void tiempoSensorAccel2(){
        int minutos = Mathf.FloorToInt(t2/60F);
        int segundos = Mathf.FloorToInt(t2 - minutos * 60);
        int milisegundos = Mathf.FloorToInt((t2-segundos)*1000);
        string texto = string.Format("{0:00}:{1:00}:{2:00}",minutos,segundos,milisegundos);
        tiempo2.text = texto;
        v2 = ((v1 + ms * t2)); //velocidad = v inicial + aceleracion * tiempo
        x2 = ((x1 + v1 + 0.5f * ms * Mathf.Pow(t2, 2)) - 1.6f); //X = x inicial + vinicial*tiempo + 1/2*aceleracion*tiempo cuadrado
        distancia2.text = "x2 = " + x2.ToString() + "m";
        tVelocidad2.text = "v2 = " + v2.ToString() + "m/s";
    }

    public void distanciaTotalAccel(){
        float v = (ms * cronometro);
        distancia.text = "x = " + ((0.5f * ms * Mathf.Pow(cronometro, 2)) - 1.6f).ToString() + "m";
        tVelocidad.text = "v = " + v.ToString() + "m/s";
    }
}
