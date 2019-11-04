using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguimiento : MonoBehaviour
{
    public Transform carro;
    public Vector3 distancia;
    // Update is called once per frame
    void Update()
    {
        transform.position = carro.position + distancia;
    }
}
