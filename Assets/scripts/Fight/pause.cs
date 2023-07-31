using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pause : MonoBehaviour
{
    
    public void pauseOn()
    {
        if(GetComponent<Text>().text == "Pause"){
            Time.timeScale = 0;
            GetComponent<Text>().text = "Continue";
        }

        else if(GetComponent<Text>().text == "Continue"){
            Time.timeScale = 1;
            GetComponent<Text>().text = "Pause";
        }
            
    }
}
