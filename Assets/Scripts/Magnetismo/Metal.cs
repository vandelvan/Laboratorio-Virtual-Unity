using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metal : MonoBehaviour
{
    public bool campoN;
    public bool campoS;
    public Rigidbody metal;
    public Transform poloN;
    public Transform poloS;
    // Start is called before the first frame update
    void Start()
    {
        metal = GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider objeto){
        if(objeto.name == "PoloN"){
            campoN = true;
        }
        if(objeto.name == "PoloS"){
            campoS = true;
        }
    }
    void OnTriggerExit(Collider objeto){
        if(objeto.name == "PoloN"){
            campoN = false;
        }
        if(objeto.name == "PoloS"){
            campoS = false;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(campoN){
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(poloN.position - transform.position), 5 * Time.deltaTime);
            transform.position += transform.forward * Time.deltaTime * 5;
        }
        if(campoS){
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(poloS.position - transform.position), 5 * Time.deltaTime);
            transform.position += transform.forward * Time.deltaTime * 5;
        }
    }
}
