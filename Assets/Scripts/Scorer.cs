using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    float xStart = 0f;
    float yStart = 1.1f;
    float zStart = -26.124f;

    float xFinish = 0f;
    float yFinish = 210f;
    float zFinish = 0f;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Enemy") {
            hits++;
            Debug.Log("Bumped this many times: " + hits); 
            transform.position = new Vector3(xStart, yStart, zStart); 
        } else if(other.gameObject.tag == "Winner") {
            Debug.Log("YOU WON AFTER " + hits + " TRIES!"); 
            transform.position = new Vector3(xFinish, yFinish, zFinish); 
        }
        
    }
}
