using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numScript9 : MonoBehaviour
{
    public SlotBool9 slot;

    void Update()
    {                                                                                       //всі предмети з числами
        if(slot.foodBool == true){
            GetComponent<Text>().text = slot.food.ToString();
            GetComponent<Text>().enabled = true; 
        }
        else
            GetComponent<Text>().enabled = false; 
    }
}
