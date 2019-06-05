using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColwithP : MonoBehaviour
{
    
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Parking Gate")
        {
            Destroy(col.gameObject);
        }
    }
}
