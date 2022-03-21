using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// void Start() {} = return nothing
public class Mover : MonoBehaviour
{
    float moveSpeed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions() 
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Use arrow keys to move around");
        Debug.Log("Avoid obstacles or get sent back to the start");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        // Using Time.deltaTime Unity can tell us how long each framework took to execute.
        // When we multiply something by Time.deltaTime it makes our game "frame rate independent"
        transform.Translate(xValue, 0, zValue);
    }
  
    //    transform.position = new Vector3(0f, 2.234f, -25.433f);
   
}
