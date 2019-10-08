using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StepTriggerScript : MonoBehaviour
{


    public GameObject canvasObject;

    private TextMeshProUGUI textObject;
    // Start is called before the first frame update
    void Start()
    {
        textObject = canvasObject.GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Need to use on trigger Enter in this script to detect when a collider enters the trigger
    //In this callback function, call our custom function steppedOnTrigger() to test! 


    void steppedOnTrigger(){
        textObject.SetText("Stepped on Trigger!");
    }

}
