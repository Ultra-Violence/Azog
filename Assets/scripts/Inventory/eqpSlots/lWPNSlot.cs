using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lWPNSlot : MonoBehaviour
{
    public GameObject MainCamera;

    public bool empty = true;

    void Update()
    {
        if(MainCamera.GetComponent<Items>().Shield_of_yura == true){
            empty = false;
            gameObject.GetComponent<Image>().enabled = true;
            gameObject.GetComponent<Image>().sprite = Resources.Load <Sprite>("Inventory/items/invicon/Shield_of_yura");
        }
    }
}
