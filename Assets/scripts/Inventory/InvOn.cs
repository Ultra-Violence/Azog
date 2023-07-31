using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvOn : MonoBehaviour
{
    public GameObject Inventory;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)){
            Inventory.SetActive(!Inventory.activeInHierarchy);
            }
    }

    public void esc_button(){
        Inventory.SetActive(false);
    }
}
