using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lArmSlot : MonoBehaviour
{
    public GameObject MainCamera;

    public bool empty = true;

    void Update()
    {
        if(MainCamera.GetComponent<Items>().Shoulder_of_yura_left == true){
            empty = false;
            gameObject.GetComponent<Image>().enabled = true;
            gameObject.GetComponent<Image>().sprite = Resources.Load <Sprite>("Inventory/items/invicon/Shoulder_of_yura_left");
        }
    }
}
