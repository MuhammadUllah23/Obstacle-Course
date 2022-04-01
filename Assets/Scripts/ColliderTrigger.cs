using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
     string objectName; 
    // Start is called before the first frame update
    void Start()
    {
        objectName = gameObject.name;
        Debug.Log(objectName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
