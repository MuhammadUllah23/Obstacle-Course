using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    float xStart;
    float yStart = 1.1f;
    float zStart = -26.124f;

    float xFinish;
    float yFinish;
    float zFinish;
    GameObject[] enemies; 
    float[][] originalPositions;
    // jagged-array or array of arrays

    void Start() {
        
        xStart = this.gameObject.transform.position.x;
        yStart = this.gameObject.transform.position.y;
        zStart = this.gameObject.transform.position.z;

        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        // array of all gameobjects with tag of enemy
        originalPositions = new float[enemies.Length][];
        // initializing jagged-array
        int i = 0;
        // index tracker
        foreach (GameObject enemy in enemies){
            float[] positions = new float[3];
            // array that takes 3 values to store a single gameObjects original position
            positions[0] = enemy.transform.position.x;
            // gameObjects x position is stored in the first index.
            positions[1] = enemy.transform.position.y;
            // gameObjects y position is stored in the second index.
            positions[2] = enemy.transform.position.z;
            // gameObjects z position is stored in the third index.

            originalPositions[i] = positions;
            // the positions array is stored in the jagged-array at index of i
            i++;
            // i is increments to store the next gameObject in the next index
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
            resetEnemies();
            
        } else if(other.gameObject.tag == "Winner") {
            Debug.Log("YOU WON AFTER " + hits + " TRIES!"); 
            transform.position = new Vector3(xFinish, yFinish, zFinish); 
        }  
    }

    void resetEnemies() {
        int i = 0;
        foreach (GameObject enemy in enemies){

            if(enemy.name.StartsWith("Dropper")){
                Rigidbody enemyRigid = enemy.GetComponent<Rigidbody>();
                enemyRigid.constraints = RigidbodyConstraints.FreezeAll;
            }
            
            float x = originalPositions[i][0];
            float y = originalPositions[i][1];
            float z = originalPositions[i][2];
            i++;
            enemy.transform.position = new Vector3(x, y, z);

        }
    }
}
