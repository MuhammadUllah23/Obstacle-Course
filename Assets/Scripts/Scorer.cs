using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    float xStart = 0f;
    float yStart = 2.234f;
    float zStart = -26.124f;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Ground") {
            
        }
        hits++;
       Debug.Log("Bumped this many times" + hits); 
       transform.position = new Vector3(xStart, yStart, zStart);
    }
}
