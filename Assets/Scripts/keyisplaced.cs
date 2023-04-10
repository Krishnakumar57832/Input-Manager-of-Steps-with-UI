using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class keyisplaced : MonoBehaviour
{
    public GameObject uiObject;
    public TMP_Text textToChange;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Cube")
        {
            //GetComponent<MeshRenderer>().enabled = false;
            uiObject.SetActive(false);
            textToChange.text = "Key is Placed";
            //Debug.Log("worked!");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Cube")
        {
            //GetComponent<MeshRenderer>().enabled = true;
            uiObject.SetActive(true);
            textToChange.text = "Key is Removed";
        }
    }
    //private void OnTriggerExit(Collider other)
    //{
    //    uiObject.SetActive(false);
    //}

}
