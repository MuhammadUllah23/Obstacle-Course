using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    public float min=2f;
    public float max=3f;
    // Use this for initialization
    void Start () {

        startMovement();
    }

    void startMovement() {
        if (gameObject.name.StartsWith("Pinger")) {
            min=transform.position.z;
            max=transform.position.z+4;
        } else if(gameObject.name.StartsWith("Ping Pong Cube")) {
            min=transform.position.x;
            max=transform.position.x+4;
        }
    }
   
    // Update is called once per frame
    void Update () {
        
        if (gameObject.name.StartsWith("Pinger")) {
            transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time*7,max-min)+min);
        } else if(gameObject.name.StartsWith("Ping Pong Cube")) {
            transform.position = new Vector3(Mathf.PingPong(Time.time*5,max-min)+min, transform.position.y, transform.position.z);
        }
          
        
    }
}
