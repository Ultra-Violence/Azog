using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryConvas : MonoBehaviour
{   
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;
    public GameObject slot6;
    public GameObject slot7;
    public GameObject slot8;
    public GameObject slot9;
    public GameObject slot10;
    public GameObject slot11;

    public Texture2D[] list_of_items;
    //public List<GameObject> list_of_items = new List<GameObject>(){};
    //public List<Texture2D> inventory_list = new List<Texture2D>(){};

    public void Add_item_inv_list(string item_name){                             //додавання icon підібраних предметів список інвентаря
        foreach(Texture2D item_from_list in list_of_items){
            if(item_from_list.name == item_name){   
                //inventory_list.Add(item_from_list);
                Sprite new_item = Resources.Load <Sprite>("Inventory/items/invicon/"+item_name);
                    if(slot1.GetComponent<SlotBool>().empty == true){
                        slot1.GetComponent<Image>().enabled = true;
                        slot1.GetComponent<Image>().sprite = new_item;
                        slot1.GetComponent<SlotBool>().empty = false;
                            if(item_name == "Helm_of_yura")                                                               //список предметів і грі
                                slot1.GetComponent<SlotBool>().eqp_head = true;
                            else if(item_name == "Armor_of_yura")
                                slot1.GetComponent<SlotBool>().eqp_body = true;
                            else if(item_name == "Shoulder_of_yura_right")
                                slot1.GetComponent<SlotBool>().eqp_rArm = true;
                            else if(item_name == "Shoulder_of_yura_left")
                                slot1.GetComponent<SlotBool>().eqp_lArm = true;
                            else if(item_name == "Boot_of_yura_right")
                                slot1.GetComponent<SlotBool>().eqp_rLeg = true;
                            else if(item_name == "Boot_of_yura_left")
                                slot1.GetComponent<SlotBool>().eqp_lLeg = true;
                            else if(item_name == "Stick_of_yura")
                                slot1.GetComponent<SlotBool>().eqp_rArm_wpn = true;
                            else if(item_name == "Spear_of_yura")
                                slot1.GetComponent<SlotBool>().eqp_rArm_wpn = true;
                            else if(item_name == "Staff_of_yura")
                                slot1.GetComponent<SlotBool>().eqp_rArm_wpn = true;
                            else if(item_name == "Shield_of_yura")
                                slot1.GetComponent<SlotBool>().eqp_lArm_wpn = true;
                            
                        }
                    else if(slot2.GetComponent<SlotBool1>().empty == true & slot1.GetComponent<SlotBool>().empty == false ){
                        slot2.GetComponent<Image>().enabled = true;
                        slot2.GetComponent<Image>().sprite = new_item;
                        slot2.GetComponent<SlotBool1>().empty = false;
                            if(item_name == "Helm_of_yura")                                                               //список предметів і грі
                                slot2.GetComponent<SlotBool1>().eqp_head = true;
                            else if(item_name == "Armor_of_yura")
                                slot2.GetComponent<SlotBool1>().eqp_body = true;
                            else if(item_name == "Shoulder_of_yura_right")
                                slot2.GetComponent<SlotBool1>().eqp_rArm = true;
                            else if(item_name == "Shoulder_of_yura_left")
                                slot2.GetComponent<SlotBool1>().eqp_lArm = true;
                            else if(item_name == "Boot_of_yura_right")
                                slot2.GetComponent<SlotBool1>().eqp_rLeg = true;
                            else if(item_name == "Boot_of_yura_left")
                                slot2.GetComponent<SlotBool1>().eqp_lLeg = true;
                            else if(item_name == "Stick_of_yura")
                                slot2.GetComponent<SlotBool1>().eqp_rArm_wpn = true;
                            else if(item_name == "Spear_of_yura")
                                slot2.GetComponent<SlotBool1>().eqp_rArm_wpn = true;
                            else if(item_name == "Staff_of_yura")
                                slot2.GetComponent<SlotBool1>().eqp_rArm_wpn = true;
                            else if(item_name == "Shield_of_yura")
                                slot2.GetComponent<SlotBool1>().eqp_lArm_wpn = true;
                            
                        }
                    else if(slot3.GetComponent<SlotBool2>().empty == true & slot2.GetComponent<SlotBool1>().empty == false ){
                        slot3.GetComponent<Image>().enabled = true;
                        slot3.GetComponent<Image>().sprite = new_item;
                        slot3.GetComponent<SlotBool2>().empty = false;
                            if(item_name == "Helm_of_yura")                                                               //список предметів і грі
                                slot3.GetComponent<SlotBool2>().eqp_head = true;
                            else if(item_name == "Armor_of_yura")
                                slot3.GetComponent<SlotBool2>().eqp_body = true;
                            else if(item_name == "Shoulder_of_yura_right")
                                slot3.GetComponent<SlotBool2>().eqp_rArm = true;
                            else if(item_name == "Shoulder_of_yura_left")
                                slot3.GetComponent<SlotBool2>().eqp_lArm = true;
                            else if(item_name == "Boot_of_yura_right")
                                slot3.GetComponent<SlotBool2>().eqp_rLeg = true;
                            else if(item_name == "Boot_of_yura_left")
                                slot3.GetComponent<SlotBool2>().eqp_lLeg = true;
                            else if(item_name == "Stick_of_yura")
                                slot3.GetComponent<SlotBool2>().eqp_rArm_wpn = true;
                            else if(item_name == "Spear_of_yura")
                                slot3.GetComponent<SlotBool2>().eqp_rArm_wpn = true;
                            else if(item_name == "Staff_of_yura")
                                slot3.GetComponent<SlotBool2>().eqp_rArm_wpn = true;
                            else if(item_name == "Shield_of_yura")
                                slot3.GetComponent<SlotBool2>().eqp_lArm_wpn = true;
                        }

                    else if(slot4.GetComponent<SlotBool3>().empty == true & slot3.GetComponent<SlotBool2>().empty == false ){
                        slot4.GetComponent<Image>().enabled = true;
                        slot4.GetComponent<Image>().sprite = new_item;
                        slot4.GetComponent<SlotBool3>().empty = false;
                            if(item_name == "Helm_of_yura")                                                               //список предметів і грі
                                slot4.GetComponent<SlotBool3>().eqp_head = true;
                            else if(item_name == "Armor_of_yura")
                                slot4.GetComponent<SlotBool3>().eqp_body = true;
                            else if(item_name == "Shoulder_of_yura_right")
                                slot4.GetComponent<SlotBool3>().eqp_rArm = true;
                            else if(item_name == "Shoulder_of_yura_left")
                                slot4.GetComponent<SlotBool3>().eqp_lArm = true;
                            else if(item_name == "Boot_of_yura_right")
                                slot4.GetComponent<SlotBool3>().eqp_rLeg = true;
                            else if(item_name == "Boot_of_yura_left")
                                slot4.GetComponent<SlotBool3>().eqp_lLeg = true;
                            else if(item_name == "Stick_of_yura")
                                slot4.GetComponent<SlotBool3>().eqp_rArm_wpn = true;
                            else if(item_name == "Spear_of_yura")
                                slot4.GetComponent<SlotBool3>().eqp_rArm_wpn = true;
                            else if(item_name == "Staff_of_yura")
                                slot4.GetComponent<SlotBool3>().eqp_rArm_wpn = true;
                            else if(item_name == "Shield_of_yura")
                                slot4.GetComponent<SlotBool3>().eqp_lArm_wpn = true;
                        }
                    else if(slot5.GetComponent<SlotBool4>().empty == true & slot4.GetComponent<SlotBool3>().empty == false ){
                        slot5.GetComponent<Image>().enabled = true;
                        slot5.GetComponent<Image>().sprite = new_item;
                        slot5.GetComponent<SlotBool4>().empty = false;
                            if(item_name == "Helm_of_yura")                                                               //список предметів і грі
                                slot5.GetComponent<SlotBool4>().eqp_head = true;
                            else if(item_name == "Armor_of_yura")
                                slot5.GetComponent<SlotBool4>().eqp_body = true;
                            else if(item_name == "Shoulder_of_yura_right")
                                slot5.GetComponent<SlotBool4>().eqp_rArm = true;
                            else if(item_name == "Shoulder_of_yura_left")
                                slot5.GetComponent<SlotBool4>().eqp_lArm = true;
                            else if(item_name == "Boot_of_yura_right")
                                slot5.GetComponent<SlotBool4>().eqp_rLeg = true;
                            else if(item_name == "Boot_of_yura_left")
                                slot5.GetComponent<SlotBool4>().eqp_lLeg = true;
                            else if(item_name == "Stick_of_yura")
                                slot5.GetComponent<SlotBool4>().eqp_rArm_wpn = true;
                            else if(item_name == "Spear_of_yura")
                                slot5.GetComponent<SlotBool4>().eqp_rArm_wpn = true;
                            else if(item_name == "Staff_of_yura")
                                slot5.GetComponent<SlotBool4>().eqp_rArm_wpn = true;
                            else if(item_name == "Shield_of_yura")
                                slot5.GetComponent<SlotBool4>().eqp_lArm_wpn = true;
                        }
                    else if(slot6.GetComponent<SlotBool5>().empty == true & slot5.GetComponent<SlotBool4>().empty == false ){
                        slot6.GetComponent<Image>().enabled = true;
                        slot6.GetComponent<Image>().sprite = new_item;
                        slot6.GetComponent<SlotBool5>().empty = false;
                            if(item_name == "Helm_of_yura")                                                               //список предметів і грі
                                slot6.GetComponent<SlotBool5>().eqp_head = true;
                            else if(item_name == "Armor_of_yura")
                                slot6.GetComponent<SlotBool5>().eqp_body = true;
                            else if(item_name == "Shoulder_of_yura_right")
                                slot6.GetComponent<SlotBool5>().eqp_rArm = true;
                            else if(item_name == "Shoulder_of_yura_left")
                                slot6.GetComponent<SlotBool5>().eqp_lArm = true;
                            else if(item_name == "Boot_of_yura_right")
                                slot6.GetComponent<SlotBool5>().eqp_rLeg = true;
                            else if(item_name == "Boot_of_yura_left")
                                slot6.GetComponent<SlotBool5>().eqp_lLeg = true;
                            else if(item_name == "Stick_of_yura")
                                slot6.GetComponent<SlotBool5>().eqp_rArm_wpn = true;
                            else if(item_name == "Spear_of_yura")
                                slot6.GetComponent<SlotBool5>().eqp_rArm_wpn = true;
                            else if(item_name == "Staff_of_yura")
                                slot6.GetComponent<SlotBool5>().eqp_rArm_wpn = true;
                            else if(item_name == "Shield_of_yura")
                                slot6.GetComponent<SlotBool5>().eqp_lArm_wpn = true;
                        }
                    else if(slot7.GetComponent<SlotBool6>().empty == true & slot6.GetComponent<SlotBool5>().empty == false ){
                        slot7.GetComponent<Image>().enabled = true;
                        slot7.GetComponent<Image>().sprite = new_item;
                        slot7.GetComponent<SlotBool6>().empty = false;
                            if(item_name == "Helm_of_yura")                                                               //список предметів і грі
                                slot7.GetComponent<SlotBool6>().eqp_head = true;
                            else if(item_name == "Armor_of_yura")
                                slot7.GetComponent<SlotBool6>().eqp_body = true;
                            else if(item_name == "Shoulder_of_yura_right")
                                slot7.GetComponent<SlotBool6>().eqp_rArm = true;
                            else if(item_name == "Shoulder_of_yura_left")
                                slot7.GetComponent<SlotBool6>().eqp_lArm = true;
                            else if(item_name == "Boot_of_yura_right")
                                slot7.GetComponent<SlotBool6>().eqp_rLeg = true;
                            else if(item_name == "Boot_of_yura_left")
                                slot7.GetComponent<SlotBool6>().eqp_lLeg = true;
                            else if(item_name == "Stick_of_yura")
                                slot7.GetComponent<SlotBool6>().eqp_rArm_wpn = true;
                            else if(item_name == "Spear_of_yura")
                                slot7.GetComponent<SlotBool6>().eqp_rArm_wpn = true;
                            else if(item_name == "Staff_of_yura")
                                slot7.GetComponent<SlotBool6>().eqp_rArm_wpn = true;
                            else if(item_name == "Shield_of_yura")
                                slot7.GetComponent<SlotBool6>().eqp_lArm_wpn = true;
                        }

                    else if(slot8.GetComponent<SlotBool7>().empty == true & slot7.GetComponent<SlotBool6>().empty == false ){
                        slot8.GetComponent<Image>().enabled = true;
                        slot8.GetComponent<Image>().sprite = new_item;
                        slot8.GetComponent<SlotBool7>().empty = false;
                            if(item_name == "Helm_of_yura")                                                               //список предметів і грі
                                slot8.GetComponent<SlotBool7>().eqp_head = true;
                            else if(item_name == "Armor_of_yura")
                                slot8.GetComponent<SlotBool7>().eqp_body = true;
                            else if(item_name == "Shoulder_of_yura_right")
                                slot8.GetComponent<SlotBool7>().eqp_rArm = true;
                            else if(item_name == "Shoulder_of_yura_left")
                                slot8.GetComponent<SlotBool7>().eqp_lArm = true;
                            else if(item_name == "Boot_of_yura_right")
                                slot8.GetComponent<SlotBool7>().eqp_rLeg = true;
                            else if(item_name == "Boot_of_yura_left")
                                slot8.GetComponent<SlotBool7>().eqp_lLeg = true;
                            else if(item_name == "Stick_of_yura")
                                slot8.GetComponent<SlotBool7>().eqp_rArm_wpn = true;
                            else if(item_name == "Spear_of_yura")
                                slot8.GetComponent<SlotBool7>().eqp_rArm_wpn = true;
                            else if(item_name == "Staff_of_yura")
                                slot8.GetComponent<SlotBool7>().eqp_rArm_wpn = true;
                            else if(item_name == "Shield_of_yura")
                                slot8.GetComponent<SlotBool7>().eqp_lArm_wpn = true;
                        }

                    else if(slot9.GetComponent<SlotBool8>().empty == true & slot8.GetComponent<SlotBool7>().empty == false ){
                        slot9.GetComponent<Image>().enabled = true;
                        slot9.GetComponent<Image>().sprite = new_item;
                        slot9.GetComponent<SlotBool8>().empty = false;
                            if(item_name == "Helm_of_yura")                                                               //список предметів і грі
                                slot9.GetComponent<SlotBool8>().eqp_head = true;
                            else if(item_name == "Armor_of_yura")
                                slot9.GetComponent<SlotBool8>().eqp_body = true;
                            else if(item_name == "Shoulder_of_yura_right")
                                slot9.GetComponent<SlotBool8>().eqp_rArm = true;
                            else if(item_name == "Shoulder_of_yura_left")
                                slot9.GetComponent<SlotBool8>().eqp_lArm = true;
                            else if(item_name == "Boot_of_yura_right")
                                slot9.GetComponent<SlotBool8>().eqp_rLeg = true;
                            else if(item_name == "Boot_of_yura_left")
                                slot9.GetComponent<SlotBool8>().eqp_lLeg = true;
                            else if(item_name == "Stick_of_yura")
                                slot9.GetComponent<SlotBool8>().eqp_rArm_wpn = true;
                            else if(item_name == "Spear_of_yura")
                                slot9.GetComponent<SlotBool8>().eqp_rArm_wpn = true;
                            else if(item_name == "Staff_of_yura")
                                slot9.GetComponent<SlotBool8>().eqp_rArm_wpn = true;
                            else if(item_name == "Shield_of_yura")
                                slot9.GetComponent<SlotBool8>().eqp_lArm_wpn = true;
                        }

                    else if(slot10.GetComponent<SlotBool9>().empty == true & slot9.GetComponent<SlotBool8>().empty == false ){
                        slot10.GetComponent<Image>().enabled = true;
                        slot10.GetComponent<Image>().sprite = new_item;
                        slot10.GetComponent<SlotBool9>().empty = false;
                            if(item_name == "Helm_of_yura")                                                               //список предметів і грі
                                slot10.GetComponent<SlotBool9>().eqp_head = true;
                            else if(item_name == "Armor_of_yura")
                                slot10.GetComponent<SlotBool9>().eqp_body = true;
                            else if(item_name == "Shoulder_of_yura_right")
                                slot10.GetComponent<SlotBool9>().eqp_rArm = true;
                            else if(item_name == "Shoulder_of_yura_left")
                                slot10.GetComponent<SlotBool9>().eqp_lArm = true;
                            else if(item_name == "Boot_of_yura_right")
                                slot10.GetComponent<SlotBool9>().eqp_rLeg = true;
                            else if(item_name == "Boot_of_yura_left")
                                slot10.GetComponent<SlotBool9>().eqp_lLeg = true;
                            else if(item_name == "Stick_of_yura")
                                slot10.GetComponent<SlotBool9>().eqp_rArm_wpn = true;
                            else if(item_name == "Spear_of_yura")
                                slot10.GetComponent<SlotBool9>().eqp_rArm_wpn = true;
                            else if(item_name == "Staff_of_yura")
                                slot10.GetComponent<SlotBool9>().eqp_rArm_wpn = true;
                            else if(item_name == "Shield_of_yura")
                                slot10.GetComponent<SlotBool9>().eqp_lArm_wpn = true;
                        }
                    
                    else if(slot11.GetComponent<SlotBool10>().empty == true & slot10.GetComponent<SlotBool9>().empty == false ){
                        slot11.GetComponent<Image>().enabled = true;
                        slot11.GetComponent<Image>().sprite = new_item;
                        slot11.GetComponent<SlotBool10>().empty = false;
                            if(item_name == "Helm_of_yura")                                                               //список предметів і грі
                                slot11.GetComponent<SlotBool10>().eqp_head = true;
                            else if(item_name == "Armor_of_yura")
                                slot11.GetComponent<SlotBool10>().eqp_body = true;
                            else if(item_name == "Shoulder_of_yura_right")
                                slot11.GetComponent<SlotBool10>().eqp_rArm = true;
                            else if(item_name == "Shoulder_of_yura_left")
                                slot11.GetComponent<SlotBool10>().eqp_lArm = true;
                            else if(item_name == "Boot_of_yura_right")
                                slot11.GetComponent<SlotBool10>().eqp_rLeg = true;
                            else if(item_name == "Boot_of_yura_left")
                                slot11.GetComponent<SlotBool10>().eqp_lLeg = true;
                            else if(item_name == "Stick_of_yura")
                                slot11.GetComponent<SlotBool10>().eqp_rArm_wpn = true;
                            else if(item_name == "Spear_of_yura")
                                slot11.GetComponent<SlotBool10>().eqp_rArm_wpn = true;
                            else if(item_name == "Staff_of_yura")
                                slot11.GetComponent<SlotBool10>().eqp_rArm_wpn = true;
                            else if(item_name == "Shield_of_yura")
                                slot11.GetComponent<SlotBool10>().eqp_lArm_wpn = true;
                        }
                    
                    
                        
            }
        }
    }

    public void Add_food_inv_list(string food_name){
        foreach(Texture2D item_from_list in list_of_items){
            if(item_from_list.name == "Food"){
                Sprite new_item = Resources.Load <Sprite>("Inventory/items/invicon/"+food_name);
                    if(slot1.GetComponent<SlotBool>().empty == true | slot1.GetComponent<SlotBool>().foodBool == true){
                        slot1.GetComponent<Image>().enabled = true;
                        slot1.GetComponent<Image>().sprite = new_item;
                        slot1.GetComponent<SlotBool>().empty = false;
                        slot1.GetComponent<SlotBool>().foodBool = true;                                                           
                        slot1.GetComponent<SlotBool>().food += 1;
                        }
                    else if(slot2.GetComponent<SlotBool1>().empty == true | slot2.GetComponent<SlotBool1>().foodBool == true){
                        slot2.GetComponent<Image>().enabled = true;
                        slot2.GetComponent<Image>().sprite = new_item;
                        slot2.GetComponent<SlotBool1>().empty = false;
                        slot2.GetComponent<SlotBool1>().foodBool = true;                                                           
                        slot2.GetComponent<SlotBool1>().food += 1;
                        }
                    else if(slot3.GetComponent<SlotBool2>().empty == true | slot3.GetComponent<SlotBool2>().foodBool == true){
                        slot3.GetComponent<Image>().enabled = true;
                        slot3.GetComponent<Image>().sprite = new_item;
                        slot3.GetComponent<SlotBool2>().empty = false;
                        slot3.GetComponent<SlotBool2>().foodBool = true;                                                           
                        slot3.GetComponent<SlotBool2>().food += 1;
                        }
                    else if(slot4.GetComponent<SlotBool3>().empty == true | slot4.GetComponent<SlotBool3>().foodBool == true){
                        slot4.GetComponent<Image>().enabled = true;
                        slot4.GetComponent<Image>().sprite = new_item;
                        slot4.GetComponent<SlotBool3>().empty = false;
                        slot4.GetComponent<SlotBool3>().foodBool = true;                                                           
                        slot4.GetComponent<SlotBool3>().food += 1;
                        }
                    else if(slot5.GetComponent<SlotBool4>().empty == true | slot5.GetComponent<SlotBool4>().foodBool == true){
                        slot5.GetComponent<Image>().enabled = true;
                        slot5.GetComponent<Image>().sprite = new_item;
                        slot5.GetComponent<SlotBool4>().empty = false;
                        slot5.GetComponent<SlotBool4>().foodBool = true;                                                           
                        slot5.GetComponent<SlotBool4>().food += 1;
                        }
                    else if(slot6.GetComponent<SlotBool5>().empty == true | slot6.GetComponent<SlotBool5>().foodBool == true){
                        slot6.GetComponent<Image>().enabled = true;
                        slot6.GetComponent<Image>().sprite = new_item;
                        slot6.GetComponent<SlotBool5>().empty = false;
                        slot6.GetComponent<SlotBool5>().foodBool = true;                                                           
                        slot6.GetComponent<SlotBool5>().food += 1;
                        }
                    else if(slot7.GetComponent<SlotBool6>().empty == true | slot7.GetComponent<SlotBool6>().foodBool == true){
                        slot7.GetComponent<Image>().enabled = true;
                        slot7.GetComponent<Image>().sprite = new_item;
                        slot7.GetComponent<SlotBool6>().empty = false;
                        slot7.GetComponent<SlotBool6>().foodBool = true;                                                           
                        slot7.GetComponent<SlotBool6>().food += 1;
                        }
                    else if(slot8.GetComponent<SlotBool7>().empty == true | slot8.GetComponent<SlotBool7>().foodBool == true){
                        slot8.GetComponent<Image>().enabled = true;
                        slot8.GetComponent<Image>().sprite = new_item;
                        slot8.GetComponent<SlotBool7>().empty = false;
                        slot8.GetComponent<SlotBool7>().foodBool = true;                                                           
                        slot8.GetComponent<SlotBool7>().food += 1;
                        }
                    else if(slot9.GetComponent<SlotBool8>().empty == true | slot9.GetComponent<SlotBool8>().foodBool == true){
                        slot9.GetComponent<Image>().enabled = true;
                        slot9.GetComponent<Image>().sprite = new_item;
                        slot9.GetComponent<SlotBool8>().empty = false;
                        slot9.GetComponent<SlotBool8>().foodBool = true;                                                           
                        slot9.GetComponent<SlotBool8>().food += 1;
                        }
                    else if(slot10.GetComponent<SlotBool9>().empty == true | slot10.GetComponent<SlotBool9>().foodBool == true){
                        slot10.GetComponent<Image>().enabled = true;
                        slot10.GetComponent<Image>().sprite = new_item;
                        slot10.GetComponent<SlotBool9>().empty = false;
                        slot10.GetComponent<SlotBool9>().foodBool = true;                                                           
                        slot10.GetComponent<SlotBool9>().food += 1;
                        }
                    else if(slot11.GetComponent<SlotBool10>().empty == true | slot11.GetComponent<SlotBool10>().foodBool == true){
                        slot11.GetComponent<Image>().enabled = true;
                        slot11.GetComponent<Image>().sprite = new_item;
                        slot11.GetComponent<SlotBool10>().empty = false;
                        slot11.GetComponent<SlotBool10>().foodBool = true;                                                           
                        slot11.GetComponent<SlotBool10>().food += 1;
                        }

    
            }
        }
}
}
