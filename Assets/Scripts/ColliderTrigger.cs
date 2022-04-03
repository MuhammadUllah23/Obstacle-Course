using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
     string objectName; 
     string[] nameSplit;
     int objectNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        objectName = gameObject.name;
        getNumber();
        // Debug.Log(objectNum + "word");
        Rigidbody dropper;
            if(objectNum == 0) {
                dropper = GameObject.Find("Dropper").GetComponent<Rigidbody>()
                dropper.useGravity = false;
            } else {
                dropper = GameObject.Find("Dropper (" + objectNum + ")").GetComponent<Rigidbody>()
                dropper.useGravity = false;
            }
        
    }

    void OnTriggerEnter (Collider other) {
        if(other.tag == "Player") {
            Rigidbody dropper;
            if(objectNum == 0) {
                dropper =  GameObject.Find("Dropper").GetComponent<Rigidbody>()
                dropper.useGravity = true;
            } else {
                dropper = GameObject.Find("Dropper (" + objectNum + ")").GetComponent<Rigidbody>()
                dropper.useGravity = true;
            }
            
        }
    }
    
    void getNumber() {
        nameSplit = objectName.Split(' ');
        // Debug.Log(nameSplit.Length + " word");
        // Debug.Log(nameSplit[0][0]);
        if(nameSplit.Length == 3) {
            
            objectNum = int.Parse(nameSplit[2][1].ToString());
    
        }
    }
}
