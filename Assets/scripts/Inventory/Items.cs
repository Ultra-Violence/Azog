using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Items : MonoBehaviour
{   
    public GameObject Hero;
    private HeroStats HeroStats;

    

    //head
    public bool Helm_of_yura = false;
    public static bool static_Helm_of_yura = false;

    //body
    public bool Armor_of_yura = false;
    public static bool static_Armor_of_yura = false;


    //r arm
    public bool Shoulder_of_yura_right = false;
    public static bool static_Shoulder_of_yura_right = false;

    //l arm
    public bool Shoulder_of_yura_left = false;
    public static bool static_Shoulder_of_yura_left = false;

    //r leg
    public bool Boot_of_yura_right = false;
    public static bool static_Boot_of_yura_right = false;

    //l leg
    public bool Boot_of_yura_left = false;
    public static bool static_Boot_of_yura_left = false;

    // r weapon
    public bool fists = true;
    public static bool static_fists = true;

    public bool Stick_of_yura = false;  
    public static bool static_Stick_of_yura = false; 

    public bool Spear_of_yura = false;
    public static bool static_Spear_of_yura = false;

    public bool Staff_of_yura = false;
    public static bool static_Staff_of_yura = false;

    // l weapon
    public bool Shield_of_yura = false;
    public static bool static_Shield_of_yura = false;

    private void Awake() {
        Helm_of_yura = static_Helm_of_yura;
        Armor_of_yura = static_Armor_of_yura;
        Shoulder_of_yura_right = static_Shoulder_of_yura_right;
        Shoulder_of_yura_left = static_Shoulder_of_yura_left;
        Boot_of_yura_right = static_Boot_of_yura_right;
        Boot_of_yura_left = static_Boot_of_yura_left;
        fists = static_fists;
        Stick_of_yura = static_Stick_of_yura;
        Spear_of_yura = static_Spear_of_yura;
        Staff_of_yura = static_Staff_of_yura;
        Shield_of_yura = static_Shield_of_yura;
        
    }

    private void Start() {
        if(SceneManager.GetActiveScene().name == "SampleScene")
            HeroStats = Hero.GetComponent<HeroStats>();
    }

    private void Update() { 
        static_Helm_of_yura = Helm_of_yura;
        static_Armor_of_yura = Armor_of_yura;
        static_Shoulder_of_yura_right = Shoulder_of_yura_right;
        static_Shoulder_of_yura_left = Shoulder_of_yura_left;
        static_Boot_of_yura_right = Boot_of_yura_right;
        static_Boot_of_yura_left = Boot_of_yura_left;
        static_fists = fists;
        static_Stick_of_yura = Stick_of_yura;
        static_Spear_of_yura = Spear_of_yura;
        static_Staff_of_yura = Staff_of_yura;
        static_Shield_of_yura = Shield_of_yura;
    }

    public void eqpHelm_of_yura(){
        Helm_of_yura = true;
        HeroStats.item_armor_head += 2;
    }

    public void eqpArmor_of_yura(){
        Armor_of_yura = true;
        HeroStats.item_armor_body += 2;
    } 

    public void eqpShoulder_of_yura_right(){
        Shoulder_of_yura_right = true;
        HeroStats.item_armor_rArm += 2;
    }

    public void eqpShoulder_of_yura_left(){
        Shoulder_of_yura_left = true;
        HeroStats.item_armor_lArm += 2;
    } 

    public void eqpBoot_of_yura_right(){
        Boot_of_yura_right = true;
        HeroStats.item_armor_rLeg += 2;
    } 

    public void eqpBoot_of_yura_left(){
        Boot_of_yura_left = true;
        HeroStats.item_armor_lLeg += 2;
    } 

    public void eqpStick_of_yura(){
        Stick_of_yura = true;
        fists = false;
        HeroStats.item_DMG += 2;
        HeroStats.str_weapon_type = true;
        HeroStats.agl_weapon_type = false;
        HeroStats.int_weapon_type = false;
    } 

    public void eqpSpear_of_yura(){
        Spear_of_yura = true;
        fists = false;
        HeroStats.item_DMG += 2;
        HeroStats.str_weapon_type = false;
        HeroStats.agl_weapon_type = true;
        HeroStats.int_weapon_type = false;
    } 

    public void eqpStaff_of_yura(){
        Staff_of_yura = true;
        fists = false;
        HeroStats.item_DMG += 2;
        HeroStats.str_weapon_type = false;
        HeroStats.agl_weapon_type = false;
        HeroStats.int_weapon_type = true;
    } 

    public void eqpShield_of_yura(){
        Shield_of_yura = true;
        HeroStats.plus_armor += 1;
    }    

}
