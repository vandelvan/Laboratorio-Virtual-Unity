using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iman : MonoBehaviour
{
    void OnMouseDrag(){
        float ejeZ = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Vector3 mov = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, ejeZ ));
        if(mov.x <= 4 && mov.x >= -4 &&
            mov.z <= -5 && mov.z >= -14){
            transform.position = new Vector3( mov.x, mov.y, mov.z );
        }
    }

    
}
