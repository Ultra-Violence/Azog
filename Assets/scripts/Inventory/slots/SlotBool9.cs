using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotBool9 : MonoBehaviour
{
    public static Sprite static_icon;

    public bool empty = true;
    public static bool static_empty = true;
    public bool foodBool = false;
    public static bool static_foodBool = false;
    public int food = 0;
    public static int static_food = 0;

    public bool eqp_head = false;
    public static bool static_eqp_head = false;
    public bool eqp_body = false;
    public static bool static_eqp_body = false;
    public bool eqp_rArm = false;
    public static bool static_eqp_rArm = false;   
    public bool eqp_lArm = false;
    public static bool static_eqp_lArm = false;   
    public bool eqp_rLeg = false;
    public static bool static_eqp_rLeg = false;  
    public bool eqp_lLeg = false;
    public static bool static_eqp_lLeg = false;
    public bool eqp_rArm_wpn = false;
    public static bool static_eqp_rArm_wpn = false;
    public bool eqp_lArm_wpn = false;
    public static bool static_eqp_lArm_wpn = false;

    void Awake() {
        GetComponent<Image>().sprite = static_icon;

        empty = static_empty;
        foodBool = static_foodBool;
        food = static_food;

        eqp_head = static_eqp_head;
        eqp_body = static_eqp_body;
        eqp_rArm = static_eqp_rArm;
        eqp_lArm = static_eqp_lArm;
        eqp_rLeg = static_eqp_rLeg;
        eqp_lLeg = static_eqp_lLeg;
        eqp_rArm_wpn = static_eqp_rArm_wpn;
        eqp_lArm_wpn = static_eqp_lArm_wpn;
    }

    void Update() {
        if(empty == false){
            GetComponent<Image>().enabled = true;
        }
        else 
            GetComponent<Image>().enabled = false;

        static_icon = GetComponent<Image>().sprite;

        static_empty = empty;
        static_foodBool = foodBool;
        static_food = food;

        static_eqp_head = eqp_head;
        static_eqp_body = eqp_body;
        static_eqp_rArm = eqp_rArm;
        static_eqp_lArm = eqp_lArm;
        static_eqp_rLeg = eqp_rLeg;
        static_eqp_lLeg = eqp_lLeg;
        static_eqp_rArm_wpn = eqp_rArm_wpn;
        static_eqp_lArm_wpn = eqp_lArm_wpn;
    }
    


}
