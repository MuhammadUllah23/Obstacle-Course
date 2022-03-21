using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other) 
    {
        hits++;
       Debug.Log("Bumped this many times" + hits); 
       transform.position = new Vector3(0f, 2.234f, -25.433f);
    }
}
