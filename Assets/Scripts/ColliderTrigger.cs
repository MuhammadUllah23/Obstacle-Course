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
        GameObject.Find("Dropper").GetComponent<Rigidbody>().useGravity = false;
    }

    void OnTriggerEnter (Collider other) {
        if(other.tag == "Player") {
            if(objectNum == 0) {
                GameObject.Find("Dropper").GetComponent<Rigidbody>().useGravity = true;
            } else {
                GameObject.Find("Dropper (" + objectNum + ")").GetComponent<Rigidbody>().useGravity = true;
            }
            
        }
    }
    
    void getNumber() {
        nameSplit = objectName.Split(' ');
        Debug.Log(nameSplit.Length + " word");
        Debug.Log(nameSplit[0][0]);
        if(nameSplit.Length == 3) {
            
            objectNum = int.Parse(nameSplit[2][1].ToString());
    
        }
    }
}
