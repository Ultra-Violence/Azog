using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rLegSlot : MonoBehaviour
{
    public GameObject MainCamera;

    public bool empty = true;

    void Update()
    {
        if(MainCamera.GetComponent<Items>().Boot_of_yura_right == true){
            empty = false;
            gameObject.GetComponent<Image>().enabled = true;
            gameObject.GetComponent<Image>().sprite = Resources.Load <Sprite>("Inventory/items/invicon/Boot_of_yura_right");
        }
    }
}
