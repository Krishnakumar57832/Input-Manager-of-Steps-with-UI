using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigent : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if( other.gameObject.tag == "Sphere")
        {
             
            Destroy(gameObject);
            
        }
    }
}