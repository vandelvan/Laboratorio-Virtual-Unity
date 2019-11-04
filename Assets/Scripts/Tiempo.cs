using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{
    public Text tiempo;
    public float cronometro;

    // Update is called once per frame
    void Update()
    {
        float minutes  = Mathf.Floor(cronometro/60);
        float seconds = Mathf.RoundToInt(cronometro%60);
        
        tiempo.text = ""+Time.deltaTime * 10;
    }
}
