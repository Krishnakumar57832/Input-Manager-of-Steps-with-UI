using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class inputgetter : MonoBehaviour
{
    [SerializeField] TMP_Text thankYouCard;
    [SerializeField] TMP_Text Input_fieldTxt;
    //public  Toggle male;
    //public Toggle female;

    public void Entry_Getter()
    {
        thankYouCard.text= Input_fieldTxt.text;
        Debug.Log(thankYouCard.text);
    }

    //public void GenderDetail()
    //{
    //    if (male == false)
    //    {
    //        Debug.Log(thankYouCard.text = "female");
    //    }
    //    else
    //    {
    //        Debug.Log(thankYouCard.text = "male");
    //    }
    //}
}
