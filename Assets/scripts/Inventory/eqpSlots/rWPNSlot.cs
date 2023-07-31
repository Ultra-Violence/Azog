using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rWPNSlot : MonoBehaviour
{
    public GameObject MainCamera;

    public bool empty = true;

    void Update()
    {
        if(MainCamera.GetComponent<Items>().Stick_of_yura == true){
            empty = false;
            gameObject.GetComponent<Image>().enabled = true;
            gameObject.GetComponent<Image>().sprite = Resources.Load <Sprite>("Inventory/items/invicon/Stick_of_yura");
        }
        else if(MainCamera.GetComponent<Items>().Spear_of_yura == true){
            empty = false;
            gameObject.GetComponent<Image>().enabled = true;
            gameObject.GetComponent<Image>().sprite = Resources.Load <Sprite>("Inventory/items/invicon/Spear_of_yura");
        }
        else if(MainCamera.GetComponent<Items>().Staff_of_yura == true){
            empty = false;
            gameObject.GetComponent<Image>().enabled = true;
            gameObject.GetComponent<Image>().sprite = Resources.Load <Sprite>("Inventory/items/invicon/Staff_of_yura");
        }
    }
}