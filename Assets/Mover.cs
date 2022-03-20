using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime;
        // Using Time.deltaTime Unity can tell us how long each framework took to execute.
        // When we multiply something by Time.deltaTime it makes our game "frame rate independent"
        transform.Translate(xValue, 0, zValue);
    }
}
