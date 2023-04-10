using Palmmedia.ReportGenerator.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class ntpcmanager : MonoBehaviour
{
    public List<Step> steps = new List<Step>();
    [HideInInspector] public Step currentStep;
    [HideInInspector] public Step previousStep;
    private int currentStepNumber = 0;



    private void OnEnable()
    {
        ProceedNextStep();
    }
    public void ProceedNextStep()
    {
        if (currentStepNumber == 0)
        {
            previousStep = null;
            currentStep = steps[0];
        }
        else
        {
            previousStep = currentStep;
            currentStep = steps[currentStepNumber];
        }
        Programcall();
        currentStepNumber++;
    }
 

    public void Programcall()
    {
        switch (currentStep.name)
        {
            case "Start":
                currentStep.uiCard.SetActive(true);
                
               
                break;
            case "Name":
                previousStep.uiCard.SetActive(false);
                currentStep.uiCard.SetActive(true);
                currentStep.enable.SetActive(true);
                 
               
                break;
            case "Email":
                previousStep.uiCard.SetActive(false);
                currentStep.uiCard.SetActive(true);
                previousStep.enable.SetActive(false);
                currentStep.enable.SetActive(true);
                break;
            case "Phone":
                previousStep.uiCard.SetActive(false);
                currentStep.uiCard.SetActive(true);
                previousStep.enable.SetActive(false);
                currentStep.enable.SetActive(true);
                break;
            case "Gender":
                previousStep.uiCard.SetActive(false);
                currentStep.uiCard.SetActive(true);
                previousStep.enable.SetActive(false);
                currentStep.enable.SetActive(true);
                break;
            case "Age":
                previousStep.uiCard.SetActive(false);
                currentStep.uiCard.SetActive(true);
                previousStep.enable.SetActive(false);
                currentStep.enable.SetActive(true);
                break;
            case "Slider":
                previousStep.uiCard.SetActive(false);
                currentStep.uiCard.SetActive(true);
                previousStep.enable.SetActive(false);
                currentStep.enable.SetActive(true);
                break;
            case "Jessica":
                previousStep.uiCard.SetActive(false);
                currentStep.uiCard.SetActive(true);
                previousStep.enable.SetActive(false);
                currentStep.enable.SetActive(true);
                break;
            case "Play":
                previousStep.uiCard.SetActive(false);
                currentStep.uiCard.SetActive(true);
                previousStep.enable.SetActive(false);
                break;
            case "Move":
                previousStep.uiCard.SetActive(false);
                currentStep.uiCard.SetActive(true);
                currentStep.enable.SetActive(true);
                currentStep.disable.SetActive(true) ;
                break;
            case "Thankyou!":
                
                previousStep.uiCard.SetActive(false);
                currentStep.uiCard.SetActive(true);
                currentStep.enable.SetActive(false);
                break;

        }
    }
 

}
[Serializable]
public class Step
{
    public string name;
    public GameObject uiCard;
    public GameObject enable;
    public GameObject disable;
    
}
