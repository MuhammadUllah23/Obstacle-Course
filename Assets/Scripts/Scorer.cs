using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    float xStart = 0f;
    float yStart = 1.1f;
    float zStart = -26.124f;

    float xFinish;
    float yFinish;
    float zFinish;
    GameObject[] enemies;
    float[][] originalPositions;

    void Start() {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        originalPositions = new float[enemies.Length][];
        int i = 0;
        foreach (GameObject enemy in enemies){
            float[] positions = new float[3];
            
            positions[0] = enemy.transform.position.x;
            positions[1] = enemy.transform.position.y;
            positions[2] = enemy.transform.position.z;

            originalPositions[i] = positions;
            Debug.Log(originalPositions);
            i++;
        }
    }
    private void OnCollisionEnter(Collision other) {
        xFinish = GameObject.Find("Winner Platform").transform.position.x;
        yFinish = GameObject.Find("Winner Platform").transform.position.y + 10;
        zFinish = GameObject.Find("Winner Platform").transform.position.z;

        
        

        if(other.gameObject.tag == "Enemy") {
            hits++;
            Debug.Log("Bumped this many times: " + hits); 
            transform.position = new Vector3(xStart, yStart, zStart); 
            foreach (GameObject enemy in enemies){

            }
            
        } else if(other.gameObject.tag == "Winner") {
            Debug.Log("YOU WON AFTER " + hits + " TRIES!"); 
            transform.position = new Vector3(xFinish, yFinish, zFinish); 
        }
        
    }
}
