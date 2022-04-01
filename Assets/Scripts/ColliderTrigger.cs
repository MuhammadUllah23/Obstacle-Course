using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
     string objectName; 
    // Start is called before the first frame update
    void Start()
    {
        objectName = gameObject.name;
        GameObject.Find("Dropper").GetComponent<Rigidbody>().useGravity = false;
    }

    void OnTriggerEnter (Collider other) {
        if(other.tag == "Player") {
            GameObject.Find("Dropper").GetComponent<Rigidbody>().useGravity = true;
        }
    }
    
}
