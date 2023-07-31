using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Xscript : MonoBehaviour
{
    public GameObject slot;             //відображення хрестика

    void Update()
    {
        if(slot.GetComponent<SlotBool>().food <= 0 & slot.GetComponent<SlotBool>().foodBool == true)
            clear();

        if(slot.GetComponent<SlotBool>().empty == false){
            gameObject.GetComponent<Image>().enabled = true;

        }
        else if(slot.GetComponent<SlotBool>().empty == true){
            gameObject.GetComponent<Image>().enabled = false;
        }
    }

        public void clear(){                                      //очищення слота
        slot.GetComponent<Image>().enabled = false;
        slot.GetComponent<SlotBool>().empty = true;
        slot.GetComponent<SlotBool>().food = 0;
        slot.GetComponent<SlotBool>().foodBool = false;
        slot.GetComponent<SlotBool>().eqp_head = false;
        slot.GetComponent<SlotBool>().eqp_body = false;
        slot.GetComponent<SlotBool>().eqp_rArm = false;   
        slot.GetComponent<SlotBool>().eqp_lArm = false;   
        slot.GetComponent<SlotBool>().eqp_rLeg = false;  
        slot.GetComponent<SlotBool>().eqp_lLeg = false;
        slot.GetComponent<SlotBool>().eqp_rArm_wpn = false;
        slot.GetComponent<SlotBool>().eqp_lArm_wpn = false;
        
    }
}
