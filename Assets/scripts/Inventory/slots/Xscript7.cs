using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Xscript7 : MonoBehaviour
{
    public GameObject slot;             //відображення хрестика

    void Update()
    {
        if(slot.GetComponent<SlotBool7>().food <= 0 & slot.GetComponent<SlotBool7>().foodBool == true)
            clear();

        if(slot.GetComponent<SlotBool7>().empty == false){
            gameObject.GetComponent<Image>().enabled = true;

        }
        else if(slot.GetComponent<SlotBool7>().empty == true){
            gameObject.GetComponent<Image>().enabled = false;
        }
    }

        public void clear(){                                      //очищення слота
        slot.GetComponent<Image>().enabled = false;
        slot.GetComponent<SlotBool7>().empty = true;
        slot.GetComponent<SlotBool7>().food = 0;
        slot.GetComponent<SlotBool7>().foodBool = false;
        slot.GetComponent<SlotBool7>().eqp_head = false;
        slot.GetComponent<SlotBool7>().eqp_body = false;
        slot.GetComponent<SlotBool7>().eqp_rArm = false;   
        slot.GetComponent<SlotBool7>().eqp_lArm = false;   
        slot.GetComponent<SlotBool7>().eqp_rLeg = false;  
        slot.GetComponent<SlotBool7>().eqp_lLeg = false;
        slot.GetComponent<SlotBool7>().eqp_rArm_wpn = false;
        slot.GetComponent<SlotBool7>().eqp_lArm_wpn = false;
        
    }
}
