using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Escript3 : MonoBehaviour
{
    public Items items;
    private string item_slot_name;

    public XrWPN XrWPN;

    public GameObject slot;
    public GameObject head_slot;
    public GameObject body_slot;
    public GameObject rArm_slot;
    public GameObject lArm_slot;
    public GameObject rLeg_slot;
    public GameObject lLeg_slot;
    public GameObject rArmWpn_slot;
    public GameObject lArmWpn_slot;

    void Update() {
        if(slot.GetComponent<SlotBool3>().empty == true){
            gameObject.GetComponent<Image>().enabled = false;
        }
        if(slot.GetComponent<SlotBool3>().eqp_head == true | slot.GetComponent<SlotBool3>().eqp_body == true | slot.GetComponent<SlotBool3>().eqp_rArm == true | slot.GetComponent<SlotBool3>().eqp_lArm == true | slot.GetComponent<SlotBool3>().eqp_rLeg == true | slot.GetComponent<SlotBool3>().eqp_lLeg == true | slot.GetComponent<SlotBool3>().eqp_rArm_wpn == true | slot.GetComponent<SlotBool3>().eqp_lArm_wpn == true){
            gameObject.GetComponent<Image>().enabled = true;
        }
        if(slot.GetComponent<SlotBool3>().empty == false){
            item_slot_name = slot.GetComponent<Image>().sprite.name;
        }
            

    }

    public void eqp(){

        Sprite eqp_item = Resources.Load <Sprite>("Inventory/items/invicon/"+item_slot_name);

        if(slot.GetComponent<SlotBool3>().eqp_head == true){
            // head_slot.GetComponent<Image>().enabled = true;
            // head_slot.GetComponent<Image>().sprite = eqp_item;
            // head_slot.GetComponent<SlotBool>().empty = false;
            if(item_slot_name == "Helm_of_yura")                               //список шоломів в грі
                items.eqpHelm_of_yura();

        }
        if(slot.GetComponent<SlotBool3>().eqp_body == true){
            // body_slot.GetComponent<Image>().enabled = true;
            // body_slot.GetComponent<Image>().sprite = eqp_item;
            // body_slot.GetComponent<SlotBool>().empty = false;
            if(item_slot_name == "Armor_of_yura")                           
                items.eqpArmor_of_yura();
            
        }
        if(slot.GetComponent<SlotBool3>().eqp_rArm == true){
            // rArm_slot.GetComponent<Image>().enabled = true;
            // rArm_slot.GetComponent<Image>().sprite = eqp_item;
            // rArm_slot.GetComponent<SlotBool>().empty = false;
            if(item_slot_name == "Shoulder_of_yura_right")                           
                items.eqpShoulder_of_yura_right();
        }
        if(slot.GetComponent<SlotBool3>().eqp_lArm == true){
            // lArm_slot.GetComponent<Image>().enabled = true;
            // lArm_slot.GetComponent<Image>().sprite = eqp_item;
            // lArm_slot.GetComponent<SlotBool>().empty = false;
            if(item_slot_name == "Shoulder_of_yura_left")                           
                items.eqpShoulder_of_yura_left();
        }
        if(slot.GetComponent<SlotBool3>().eqp_rLeg == true){
            // rLeg_slot.GetComponent<Image>().enabled = true;
            // rLeg_slot.GetComponent<Image>().sprite = eqp_item;
            // rLeg_slot.GetComponent<SlotBool>().empty = false;
            if(item_slot_name == "Boot_of_yura_right")                           
                items.eqpBoot_of_yura_right();
        }
        if(slot.GetComponent<SlotBool3>().eqp_lLeg == true){
            // lLeg_slot.GetComponent<Image>().enabled = true;
            // lLeg_slot.GetComponent<Image>().sprite = eqp_item;
            // lLeg_slot.GetComponent<SlotBool>().empty = false;
            if(item_slot_name == "Boot_of_yura_left")                           
                items.eqpBoot_of_yura_left();
        }
        if(slot.GetComponent<SlotBool3>().eqp_rArm_wpn == true){
            XrWPN.clear();
            // rArmWpn_slot.GetComponent<Image>().enabled = true;
            // rArmWpn_slot.GetComponent<Image>().sprite = eqp_item;
            // rArmWpn_slot.GetComponent<SlotBool>().empty = false;
            if(item_slot_name == "Stick_of_yura")                           
                items.eqpStick_of_yura();
            else if(item_slot_name == "Spear_of_yura")                           
                items.eqpSpear_of_yura();
            else if(item_slot_name == "Staff_of_yura")                           
                items.eqpStaff_of_yura();
        }
        if(slot.GetComponent<SlotBool3>().eqp_lArm_wpn == true){
            // lArmWpn_slot.GetComponent<Image>().enabled = true;
            // lArmWpn_slot.GetComponent<Image>().sprite = eqp_item;
            // lArmWpn_slot.GetComponent<SlotBool>().empty = false;
            if(item_slot_name == "Shield_of_yura")                           
                items.eqpShield_of_yura();
        }

            slot.GetComponent<Image>().enabled = false;
            slot.GetComponent<SlotBool3>().empty = true;
            slot.GetComponent<SlotBool3>().eqp_head = false;
            slot.GetComponent<SlotBool3>().eqp_body = false;
            slot.GetComponent<SlotBool3>().eqp_rArm = false;   
            slot.GetComponent<SlotBool3>().eqp_lArm = false;   
            slot.GetComponent<SlotBool3>().eqp_rLeg = false;  
            slot.GetComponent<SlotBool3>().eqp_lLeg = false;
            slot.GetComponent<SlotBool3>().eqp_rArm_wpn = false;
            slot.GetComponent<SlotBool3>().eqp_lArm_wpn = false;
    }
}
