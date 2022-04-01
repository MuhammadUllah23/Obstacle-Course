using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
     string objectName; 
     string[] nameSplit;
     char objectNum;
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
            GameObject.Find("Dropper").GetComponent<Rigidbody>().useGravity = true;
        }
    }
    
    void getNumber() {
        nameSplit = objectName.Split(' ');
        Debug.Log(nameSplit.Length + " word");
        Debug.Log(nameSplit[0][0]);
        if(nameSplit.Length == 3) {
            objectNum = nameSplit[2][1];
        }
    }
}
