using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Xscript1 : MonoBehaviour
{
    public GameObject slot;             //відображення хрестика

    void Update()
    {
        if(slot.GetComponent<SlotBool1>().food <= 0 & slot.GetComponent<SlotBool1>().foodBool == true)
            clear();

        if(slot.GetComponent<SlotBool1>().empty == false){
            gameObject.GetComponent<Image>().enabled = true;

        }
        else if(slot.GetComponent<SlotBool1>().empty == true){
            gameObject.GetComponent<Image>().enabled = false;
        }
    }

        public void clear(){                                      //очищення слота
        slot.GetComponent<Image>().enabled = false;
        slot.GetComponent<SlotBool1>().empty = true;
        slot.GetComponent<SlotBool1>().food = 0;
        slot.GetComponent<SlotBool1>().foodBool = false;
        slot.GetComponent<SlotBool1>().eqp_head = false;
        slot.GetComponent<SlotBool1>().eqp_body = false;
        slot.GetComponent<SlotBool1>().eqp_rArm = false;   
        slot.GetComponent<SlotBool1>().eqp_lArm = false;   
        slot.GetComponent<SlotBool1>().eqp_rLeg = false;  
        slot.GetComponent<SlotBool1>().eqp_lLeg = false;
        slot.GetComponent<SlotBool1>().eqp_rArm_wpn = false;
        slot.GetComponent<SlotBool1>().eqp_lArm_wpn = false;
        
    }
}
