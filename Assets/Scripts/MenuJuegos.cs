using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuJuegos : MonoBehaviour
{
    public void movimiento(){
        SceneManager.LoadScene("Movimiento");
    }
    public void movimientoAcelerado(){
        SceneManager.LoadScene("MovimientoAcelerado");
    }
    public void caida(){
        SceneManager.LoadScene("Caida");
    }
    public void magnetismo(){
        SceneManager.LoadScene("Magnetismo");
    }
    public void volver(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
