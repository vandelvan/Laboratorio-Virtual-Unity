using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuJuegos : MonoBehaviour
{
    public void movimiento(){
        SceneManager.LoadScene("Movimiento");
    }
    
    public void volver(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
