using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoloSur : MonoBehaviour
{
    public Rigidbody iman;
    private bool force;
    void OnTriggerStay(Collider objeto){
        if(objeto.name == "PoloN" && objeto is SphereCollider){
            objeto.isTrigger = true;
            force = false;
        }
        else if(objeto.name == "PoloS" && objeto is SphereCollider){
            objeto.isTrigger = false;
            force = true;
        }
    }
    void OnTriggerExit(Collider objeto){
        if(objeto is SphereCollider){
            objeto.isTrigger = true;
            iman.velocity = new Vector3(0,0,0);
            force = false;
        }
    }

    void FixedUpdate(){
        if(force){
            iman.AddForce(200,0,200);
        }
        else{
            iman.velocity = new Vector3(0,0,0);
        }
    }
}
