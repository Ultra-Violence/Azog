using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HeroStats : MonoBehaviour
{
    public int strength = 1;
    public static int static_strength = 1;
    public int agility = 1;
    public static int static_agility = 1;
    public int intelligence = 1;
    public static int static_intelligence = 1;

    public float HP_max = 1f;
    public float HP_rn = 1f;

    public float HP_head_max = 20f;
    public static float static_HP_head_max = 20f;
    public float HP_head_rn = 20f;
    public static float HP_head = 20f;
    public float armor_head = 0f;
    public float item_armor_head = 0f;
    public static float static_item_armor_head = 0f;

    public float HP_body_max = 80f;
    public static float static_HP_body_max = 80f;
    public float HP_body_rn = 80f;
    public static float HP_body = 80f;
    public float armor_body = 0f;
    public float item_armor_body = 0f;
    public static float static_item_armor_body = 0f;

    public float HP_rArm_max = 40f;
    public static float static_HP_rArm_max = 40f;
    public float HP_rArm_rn = 40f;
    public static float HP_rArm = 40f;
    public float armor_rArm = 0f;
    public float item_armor_rArm = 0f;
    public static float static_item_armor_rArm = 0f;

    public float HP_lArm_max = 40f;
    public static float static_HP_lArm_max = 40f;
    public float HP_lArm_rn = 40f;
    public static float HP_lArm = 40f;
    public float armor_lArm = 0f;
    public float item_armor_lArm = 0f;
    public static float static_item_armor_lArm = 0f;

    public float HP_rLeg_max = 50f;
    public static float static_HP_rLeg_max = 50f;
    public float HP_rLeg_rn = 50f;
    public static float HP_rLeg = 50f;
    public float armor_rLeg = 0f;
    public float item_armor_rLeg = 0f;
    public static float static_item_armor_rLeg = 0f;

    public float HP_lLeg_max = 50f;
    public static float static_HP_lLeg_max = 50f;
    public float HP_lLeg_rn = 50f;
    public static float HP_lLeg = 50f;
    public float armor_lLeg = 0f;
    public float item_armor_lLeg = 0f;
    public static float static_item_armor_lLeg = 0f;

    // public float item_weapon_rArm = 0f;
    // public static float static_item_weapon_rArm = 0f;
    // public float item_weapon_lArm = 0f;
    // public static float static_item_weapon_lArm = 0f;

    public bool str_weapon_type = true;
    public bool agl_weapon_type = false;
    public bool int_weapon_type = false; 

    public int minus_enemy_armor = 0;
    static public int static_minus_enemy_armor = 0;
    public int plus_armor = 0;
    static public int static_plus_armor = 0;
    public float DMG = 5f;
    public float item_DMG = 0f;
    public static float static_item_DMG = 0f;
    public float exp_modificator = 1f;
    public static float static_exp_modificator = 1f;

    //травми

    public int head_trauma_armor_modifier = 0;     // сейв армор від травм
    public int body_trauma_armor_modifier = 0;
    public int rArm_trauma_armor_modifier = 0;
    public int lArm_trauma_armor_modifier = 0;
    public int rLeg_trauma_armor_modifier = 0;
    public int lLeg_trauma_armor_modifier = 0;
    public int trauma_modificator_DMG = 0;

    public static int static_head_trauma_armor_modifier = 0;
    public static int static_body_trauma_armor_modifier = 0;
    public static int static_rArm_trauma_armor_modifier = 0;
    public static int static_lArm_trauma_armor_modifier = 0;
    public static int static_rLeg_trauma_armor_modifier = 0;
    public static int static_lLeg_trauma_armor_modifier = 0;
    public static int static_trauma_modificator_DMG = 0;

    List<string> head_trauma = new List<string>() { "concussion","pierced_skull" };
    static public bool static_trauma_concussion = false;
    static public bool static_trauma_pierced_skull = false;
    public bool trauma_concussion = false;
    public bool trauma_pierced_skull = false;

    List<string> body_trauma = new List<string>() { "hit_heart","damaged_left_lung","damaged_right_lung" };
    static public bool static_trauma_hit_heart = false;
    static public bool static_trauma_damaged_right_lung = false;
    static public bool static_trauma_damaged_left_lung = false;
    public bool trauma_hit_heart = false;
    public bool trauma_damaged_right_lung = false;
    public bool trauma_damaged_left_lung = false;

    List<string> rArm_trauma = new List<string>() { "severed_rThumb","severed_rIndex", "severed_rMiddle", "severed_rRing", "severed_rLittle","rHand_fracture","rElbow_fracture", "rClavicle_fracture" };   
    static public bool static_trauma_severed_rThumb = false;
    static public bool static_trauma_severed_rIndex = false;
    static public bool static_trauma_severed_rMiddle = false;
    static public bool static_trauma_severed_rRing = false;
    static public bool static_trauma_severed_rLittle = false;
    static public bool static_trauma_rHand_fracture = false;
    static public bool static_trauma_rElbow_fracture = false;
    static public bool static_trauma_rClavicle_fracture = false;
    public bool trauma_severed_rThumb = false;
    public bool trauma_severed_rIndex = false;
    public bool trauma_severed_rMiddle = false;
    public bool trauma_severed_rRing = false;
    public bool trauma_severed_rLittle = false;
    public bool trauma_rHand_fracture = false;
    public bool trauma_rElbow_fracture = false;
    public bool trauma_rClavicle_fracture = false;

    List<string> lArm_trauma = new List<string>() { "severed_lThumb","severed_lIndex", "severed_lMiddle", "severed_lRing", "severed_lLittle","lHand_fracture","lElbow_fracture", "lClavicle_fracture" };   
    static public bool static_trauma_severed_lThumb = false;
    static public bool static_trauma_severed_lIndex = false;
    static public bool static_trauma_severed_lMiddle = false;
    static public bool static_trauma_severed_lRing = false;
    static public bool static_trauma_severed_lLittle = false;
    static public bool static_trauma_lHand_fracture = false;
    static public bool static_trauma_lElbow_fracture = false;
    static public bool static_trauma_lClavicle_fracture = false;
    public bool trauma_severed_lThumb = false;
    public bool trauma_severed_lIndex = false;
    public bool trauma_severed_lMiddle = false;
    public bool trauma_severed_lRing = false;
    public bool trauma_severed_lLittle = false;
    public bool trauma_lHand_fracture = false;
    public bool trauma_lElbow_fracture = false;
    public bool trauma_lClavicle_fracture = false;

    List<string> rLeg_trauma = new List<string>() { "rKnee_fracture","rFoot_fracture" };
    static public bool static_trauma_rKnee_fracture = false;
    static public bool static_trauma_rFoot_fracture = false;
    public bool trauma_rKnee_fracture = false;
    public bool trauma_rFoot_fracture = false;

    List<string> lLeg_trauma = new List<string>() { "lKnee_fracture","lFoot_fracture" };
    static public bool static_trauma_lKnee_fracture = false;
    static public bool static_trauma_lFoot_fracture = false;
    public bool trauma_lKnee_fracture = false;
    public bool trauma_lFoot_fracture = false;

    private void Awake() {

        strength = static_strength;        // сейв статів
        agility = static_agility;
        intelligence = static_intelligence;

        HP_head_rn = HP_head;  //сейв здоров'я між сценами
        HP_body_rn = HP_body;
        HP_lArm_rn = HP_lArm;
        HP_rArm_rn = HP_rArm;
        HP_lLeg_rn = HP_lLeg;
        HP_rLeg_rn = HP_rLeg;

        HP_head_max = static_HP_head_max;   // сейв
        HP_body_max = static_HP_body_max;
        HP_rArm_max = static_HP_rArm_max;
        HP_lArm_max = static_HP_lArm_max;
        HP_rLeg_max = static_HP_rLeg_max;
        HP_lLeg_max = static_HP_lLeg_max;

        item_armor_head = static_item_armor_head;         //сейв армора з предметів
        item_armor_body = static_item_armor_body;
        item_armor_rArm = static_item_armor_rArm;
        item_armor_lArm = static_item_armor_lArm;
        item_armor_rLeg = static_item_armor_rLeg;
        item_armor_lLeg = static_item_armor_lLeg;

        head_trauma_armor_modifier = static_head_trauma_armor_modifier;    // сейв армор від травм
        body_trauma_armor_modifier = static_body_trauma_armor_modifier;
        rArm_trauma_armor_modifier = static_rArm_trauma_armor_modifier;
        lArm_trauma_armor_modifier = static_lArm_trauma_armor_modifier;
        rLeg_trauma_armor_modifier = static_rLeg_trauma_armor_modifier;
        lLeg_trauma_armor_modifier = static_lLeg_trauma_armor_modifier;

        trauma_modificator_DMG = static_trauma_modificator_DMG;

        item_DMG = static_item_DMG;

        exp_modificator = static_exp_modificator;
        plus_armor = static_plus_armor;
        minus_enemy_armor = static_minus_enemy_armor;

        trauma_concussion = static_trauma_concussion;         //сейв травм голови
        trauma_pierced_skull = static_trauma_pierced_skull;

        trauma_hit_heart = static_trauma_hit_heart;                             //сейв травм тіла
        trauma_damaged_right_lung = static_trauma_damaged_right_lung;
        trauma_damaged_left_lung = static_trauma_damaged_left_lung;

        trauma_severed_rThumb = static_trauma_severed_rThumb;            //сейв травм правої руки
        trauma_severed_rIndex = static_trauma_severed_rIndex;
        trauma_severed_rMiddle = static_trauma_severed_rMiddle;
        trauma_severed_rRing = static_trauma_severed_rRing;
        trauma_severed_rLittle = static_trauma_severed_rLittle;
        trauma_rHand_fracture = static_trauma_rHand_fracture;
        trauma_rElbow_fracture = static_trauma_rElbow_fracture;
        trauma_rClavicle_fracture = static_trauma_rClavicle_fracture;

        trauma_severed_lThumb = static_trauma_severed_lThumb;            //сейв травм лівої руки
        trauma_severed_lIndex = static_trauma_severed_lIndex;
        trauma_severed_lMiddle = static_trauma_severed_lMiddle;
        trauma_severed_lRing = static_trauma_severed_lRing;
        trauma_severed_lLittle = static_trauma_severed_lLittle;
        trauma_lHand_fracture = static_trauma_lHand_fracture;
        trauma_lElbow_fracture = static_trauma_lElbow_fracture;
        trauma_lClavicle_fracture = static_trauma_lClavicle_fracture;

        trauma_rKnee_fracture = static_trauma_rKnee_fracture;
        trauma_rFoot_fracture = static_trauma_rFoot_fracture;

        trauma_lKnee_fracture = static_trauma_lKnee_fracture;
        trauma_lFoot_fracture = static_trauma_lFoot_fracture;

    
    }

    void Update() {
        
        static_strength = strength;               // сейв статів
        static_agility = agility;
        static_intelligence = intelligence;

        armor_head = agility + plus_armor + item_armor_head + head_trauma_armor_modifier;    // сейв
        armor_body = agility + plus_armor + item_armor_body + body_trauma_armor_modifier;
        armor_rArm = agility + plus_armor + item_armor_rArm + rArm_trauma_armor_modifier;
        armor_lArm = agility + plus_armor + item_armor_lArm + lArm_trauma_armor_modifier;
        armor_rLeg = agility + plus_armor + item_armor_rLeg + rLeg_trauma_armor_modifier;
        armor_lLeg = agility + plus_armor + item_armor_lLeg + lLeg_trauma_armor_modifier;

        HP_head = HP_head_rn;  //сейв здоров'я між сценами
        HP_body = HP_body_rn;
        HP_lArm = HP_lArm_rn;
        HP_rArm = HP_rArm_rn;
        HP_lLeg = HP_lLeg_rn;
        HP_rLeg = HP_rLeg_rn;

        static_HP_head_max = HP_head_max;     // сейв
        static_HP_body_max = HP_body_max;
        static_HP_rArm_max = HP_rArm_max;
        static_HP_lArm_max = HP_lArm_max;
        static_HP_rLeg_max = HP_rLeg_max;
        static_HP_lLeg_max = HP_lLeg_max;

        static_item_armor_head = item_armor_head;               //сейв армора з предметів
        static_item_armor_body = item_armor_body;
        static_item_armor_rArm = item_armor_rArm;
        static_item_armor_lArm = item_armor_lArm;
        static_item_armor_rLeg = item_armor_rLeg;
        static_item_armor_lLeg = item_armor_lLeg;

        static_head_trauma_armor_modifier = head_trauma_armor_modifier;    // сейв армор від травм
        static_body_trauma_armor_modifier = body_trauma_armor_modifier;
        static_rArm_trauma_armor_modifier = rArm_trauma_armor_modifier;
        static_lArm_trauma_armor_modifier = lArm_trauma_armor_modifier;
        static_rLeg_trauma_armor_modifier = rLeg_trauma_armor_modifier;
        static_lLeg_trauma_armor_modifier = lLeg_trauma_armor_modifier;

        static_trauma_modificator_DMG = trauma_modificator_DMG;

        static_item_DMG = item_DMG;

        static_exp_modificator = exp_modificator;
        static_plus_armor = plus_armor;
        static_minus_enemy_armor = minus_enemy_armor;

        static_trauma_concussion = trauma_concussion;
        static_trauma_pierced_skull = trauma_pierced_skull;

        static_trauma_hit_heart = trauma_hit_heart;
        static_trauma_damaged_right_lung = trauma_damaged_right_lung;
        static_trauma_damaged_left_lung = trauma_damaged_left_lung;

        static_trauma_severed_rThumb = trauma_severed_rThumb;
        static_trauma_severed_rIndex = trauma_severed_rIndex;
        static_trauma_severed_rMiddle = trauma_severed_rMiddle;
        static_trauma_severed_rRing = trauma_severed_rRing;
        static_trauma_severed_rLittle = trauma_severed_rLittle;
        static_trauma_rHand_fracture = trauma_rHand_fracture;
        static_trauma_rElbow_fracture = trauma_rElbow_fracture;
        static_trauma_rClavicle_fracture = trauma_rClavicle_fracture;

        static_trauma_severed_lThumb = trauma_severed_lThumb;
        static_trauma_severed_lIndex = trauma_severed_lIndex;
        static_trauma_severed_lMiddle = trauma_severed_lMiddle;
        static_trauma_severed_lRing = trauma_severed_lRing;
        static_trauma_severed_lLittle = trauma_severed_lLittle;
        static_trauma_lHand_fracture = trauma_lHand_fracture;
        static_trauma_lElbow_fracture = trauma_lElbow_fracture;
        static_trauma_lClavicle_fracture = trauma_lClavicle_fracture;

        static_trauma_rKnee_fracture = trauma_rKnee_fracture;
        static_trauma_rFoot_fracture = trauma_rFoot_fracture;

        static_trauma_lKnee_fracture = trauma_lKnee_fracture;
        static_trauma_lFoot_fracture = trauma_lFoot_fracture;


        if( str_weapon_type == true){   //dmg
            DMG = 5f + strength + item_DMG + trauma_modificator_DMG;
        }
        if( agl_weapon_type == true){
            DMG = 5f + agility + item_DMG + trauma_modificator_DMG;
        }
        if( int_weapon_type == true){
            DMG = 5f + intelligence + item_DMG + trauma_modificator_DMG;
        }



        if(HP_rn > HP_max)       //щоб поточний рівень здоров'я не перевищував максимальний
            HP_rn = HP_max;

        if(HP_rn <= 0 & SceneManager.GetActiveScene().name == "SampleScene" ){                      //смерть
            HP_head = HP_head_max;
            HP_body = HP_body_max;
            HP_rArm = HP_rArm_max;
            HP_lArm = HP_lArm_max;
            HP_rLeg = HP_rLeg_max;
            HP_lLeg = HP_lLeg_max;
            SceneManager.LoadScene(4);
            }

        if(HP_body_rn <= 0 | HP_head_rn <= 0 & SceneManager.GetActiveScene().name == "SampleScene" ){
            HP_head = HP_head_max;
            HP_body = HP_body_max;
            HP_rArm = HP_rArm_max;
            HP_lArm = HP_lArm_max;
            HP_rLeg = HP_rLeg_max;
            HP_lLeg = HP_lLeg_max;
            SceneManager.LoadScene(4);
            }
            
        if(HP_head_rn > HP_head_max)
            HP_head_rn = HP_head_max;
        
        if(HP_body_rn > HP_body_max)
            HP_body_rn = HP_body_max;
        
        if(HP_lArm_rn > HP_lArm_max)
            HP_lArm_rn = HP_lArm_max;
        
        if(HP_rArm_rn > HP_rArm_max)
            HP_rArm_rn = HP_rArm_max;
        
        if(HP_lLeg_rn > HP_lLeg_max)
            HP_lLeg_rn = HP_lLeg_max;

        if(HP_rLeg_rn > HP_rLeg_max)
            HP_rLeg_rn = HP_rLeg_max;

        HP_max = HP_head_max + HP_body_max + HP_lArm_max + HP_rArm_max + HP_lLeg_max + HP_rLeg_max ;

        HP_rn = HP_head_rn + HP_body_rn + HP_lArm_rn + HP_rArm_rn + HP_lLeg_rn + HP_rLeg_rn;

    }

    public void hit_head(float damage){

        System.Random random_d20 = new System.Random();
        int random_d20_trauma = random_d20.Next(5);

        if(random_d20_trauma == 1 & damage >= HP_head_max*0.1f){
            System.Random random = new System.Random();                             //новий рандом
            int random_head_trauma_index = random.Next(head_trauma.Count);          //некст дозволяє брати число від 0 до заданого
            string random_head_trauma = head_trauma[random_head_trauma_index];      //обираємо випадковий індекс

            if(random_head_trauma == "concussion"){
                concussion_trauma();
                
            }
            else if(random_head_trauma == "pierced_skull"){
                pierced_skull_trauma();
            }
        }

        HP_head_rn -= damage*2;
        HP_head = HP_head_rn;

        if(HP_head_rn <= 0 & SceneManager.GetActiveScene().name == "SampleScene" ){
            SceneManager.LoadScene(4);
            }
    }

    public void hit_body(float damage){

        System.Random random_d20 = new System.Random();
        int random_d20_trauma = random_d20.Next(5);

        if(random_d20_trauma == 1 & damage >= HP_body_max*0.1f){
            System.Random random = new System.Random();                             //новий рандом
            int random_body_trauma_index = random.Next(body_trauma.Count);          //некст дозволяє брати число від 0 до заданого 
            string random_body_trauma = body_trauma[random_body_trauma_index];      //обираємо випадковий індекс

            if(random_body_trauma == "hit_heart"){
                hit_heart_trauma();
            } 
            else if(random_body_trauma == "damaged_left_lung"){
                damaged_left_lung_trauma();
            }
            else if(random_body_trauma == "damaged_right_lung"){
                damaged_right_lung_trauma();
            }
                
        }

        HP_body_rn -= damage;
        HP_body = HP_body_rn;

        if(HP_body_rn <= 0 & SceneManager.GetActiveScene().name == "SampleScene"  ){
            SceneManager.LoadScene(4);
            }
    }
        

    public void hit_rArm(float damage){
        System.Random random_d20 = new System.Random();
        int random_d20_trauma = random_d20.Next(5);

        if(random_d20_trauma == 1 & damage >= HP_rArm_max*0.1f){
            System.Random random = new System.Random();                             //новий рандом
            int random_rArm_trauma_index = random.Next(rArm_trauma.Count);          //некст дозволяє брати число від 0 до заданого 
            string random_rArm_trauma = rArm_trauma[random_rArm_trauma_index];      //обираємо випадковий індекс

            if(random_rArm_trauma == "severed_rThumb"){
                severed_rThumb_trauma();
            } 
            else if(random_rArm_trauma == "severed_rIndex"){
                severed_rIndex_trauma();
            }
            else if(random_rArm_trauma == "severed_rMiddle"){
                severed_rMiddle_trauma();
            }
            else if(random_rArm_trauma == "severed_rRing"){
                severed_rRing_trauma();
            }
            else if(random_rArm_trauma == "severed_rLittle"){
                severed_rLittle_trauma();
            }
            else if(random_rArm_trauma == "rHand_fracture"){
                rHand_fracture_trauma();
            }
            else if(random_rArm_trauma == "rElbow_fracture"){
                rElbow_fracture_trauma();
            }
            else if(random_rArm_trauma == "rClavicle_fracture"){
                rClavicle_fracture_trauma();
            }     
        }

        HP_rArm_rn -= damage;
        HP_rArm = HP_rArm_rn;
    }

    public void hit_lArm(float damage){

        System.Random random_d20 = new System.Random();
        int random_d20_trauma = random_d20.Next(5);

        if(random_d20_trauma == 1 & damage >= HP_lArm_max*0.1f){
            System.Random random = new System.Random();                             //новий рандом
            int random_lArm_trauma_index = random.Next(lArm_trauma.Count);          //некст дозволяє брати число від 0 до заданого 
            string random_lArm_trauma = lArm_trauma[random_lArm_trauma_index];      //обираємо випадковий індекс

            if(random_lArm_trauma == "severed_lThumb"){
                severed_lThumb_trauma();
            } 
            else if(random_lArm_trauma == "severed_lIndex"){
                severed_lIndex_trauma();
            }
            else if(random_lArm_trauma == "severed_lMiddle"){
                severed_lMiddle_trauma();
            }
            else if(random_lArm_trauma == "severed_lRing"){
                severed_lRing_trauma();
            }
            else if(random_lArm_trauma == "severed_lLittle"){
                severed_lLittle_trauma();
            }
            else if(random_lArm_trauma == "lHand_fracture"){
                lHand_fracture_trauma();
            }
            else if(random_lArm_trauma == "lElbow_fracture"){
                lElbow_fracture_trauma();
            }
            else if(random_lArm_trauma == "lClavicle_fracture"){
                lClavicle_fracture_trauma();
            }     
        }
        HP_lArm_rn -= damage;
        HP_lArm = HP_lArm_rn;
    }

    public void hit_rLeg(float damage){

        System.Random random_d20 = new System.Random();
        int random_d20_trauma = random_d20.Next(5);

        if(random_d20_trauma == 1 & damage >= HP_rLeg_max*0.1f){
            System.Random random = new System.Random();                             //новий рандом
            int random_rLeg_trauma_index = random.Next(rLeg_trauma.Count);          //некст дозволяє брати число від 0 до заданого 
            string random_rLeg_trauma = rLeg_trauma[random_rLeg_trauma_index];      //обираємо випадковий індекс

            if(random_rLeg_trauma == "rKnee_fracture"){
                rKnee_fracture_trauma();
            } 
            else if(random_rLeg_trauma == "rFoot_fracture"){
                rFoot_fracture_trauma();
            }   
        }

        HP_rLeg_rn -= damage;
        HP_rLeg = HP_rLeg_rn;
    }

    public void hit_lLeg(float damage){

        System.Random random_d20 = new System.Random();
        int random_d20_trauma = random_d20.Next(5);

        if(random_d20_trauma == 1 & damage >= HP_lLeg_max*0.1f){
            System.Random random = new System.Random();                             //новий рандом
            int random_lLeg_trauma_index = random.Next(lLeg_trauma.Count);          //некст дозволяє брати число від 0 до заданого 
            string random_lLeg_trauma = lLeg_trauma[random_lLeg_trauma_index];      //обираємо випадковий індекс

            if(random_lLeg_trauma == "lKnee_fracture"){
                lKnee_fracture_trauma();
            } 
            else if(random_lLeg_trauma == "lFoot_fracture"){
                lFoot_fracture_trauma();
            }   
        }

        HP_lLeg_rn -= damage;
        HP_lLeg = HP_lLeg_rn;
    }

    //список травм

    public void concussion_trauma(){
        trauma_concussion = true;
        exp_modificator = exp_modificator*0.5f;
    }

    public void pierced_skull_trauma(){
        trauma_pierced_skull = true;
        head_trauma_armor_modifier = head_trauma_armor_modifier - 2;
    }

    public void hit_heart_trauma(){
        trauma_hit_heart = true;
        HP_body_rn = 0;
    }

    public void damaged_left_lung_trauma(){
        trauma_damaged_left_lung = true;
        body_trauma_armor_modifier = body_trauma_armor_modifier - 2;
    }

    public void damaged_right_lung_trauma(){
        trauma_damaged_right_lung = true;
        body_trauma_armor_modifier = body_trauma_armor_modifier - 2;
    }

    public void severed_rThumb_trauma(){
        trauma_severed_rThumb = true;
        trauma_modificator_DMG = trauma_modificator_DMG - 1;
    }    

    public void severed_rIndex_trauma(){
        trauma_severed_rIndex = true;
        trauma_modificator_DMG = trauma_modificator_DMG - 1;
    }

    public void severed_rMiddle_trauma(){
        trauma_severed_rMiddle = true;
        trauma_modificator_DMG = trauma_modificator_DMG - 1;
    }

    public void severed_rRing_trauma(){
        trauma_severed_rRing = true;
        trauma_modificator_DMG = trauma_modificator_DMG - 1;
    }

    public void severed_rLittle_trauma(){
        trauma_severed_rLittle = true;
        trauma_modificator_DMG = trauma_modificator_DMG - 1;
    }

    public void rHand_fracture_trauma(){
        trauma_rHand_fracture = true;
        trauma_modificator_DMG = trauma_modificator_DMG - 1;
    }

    public void rElbow_fracture_trauma(){
        trauma_rElbow_fracture = true;
        trauma_modificator_DMG = trauma_modificator_DMG - 2;
    }

    public void rClavicle_fracture_trauma(){
        trauma_rClavicle_fracture = true;
        trauma_modificator_DMG = trauma_modificator_DMG - 3;
    }

    public void severed_lThumb_trauma(){
        trauma_severed_lThumb = true;
        lArm_trauma_armor_modifier = lArm_trauma_armor_modifier - 1;
    }    

    public void severed_lIndex_trauma(){
        trauma_severed_lIndex = true;
        lArm_trauma_armor_modifier = lArm_trauma_armor_modifier - 1;
    }

    public void severed_lMiddle_trauma(){
        trauma_severed_lMiddle = true;
        lArm_trauma_armor_modifier = lArm_trauma_armor_modifier - 1;
    }

    public void severed_lRing_trauma(){
        trauma_severed_lRing = true;
        lArm_trauma_armor_modifier = lArm_trauma_armor_modifier - 1;
    }

    public void severed_lLittle_trauma(){
        trauma_severed_lLittle = true;
        lArm_trauma_armor_modifier = lArm_trauma_armor_modifier - 1;
    }

    public void lHand_fracture_trauma(){
        trauma_lHand_fracture = true;
        trauma_modificator_DMG = trauma_modificator_DMG - 1;
    }

    public void lElbow_fracture_trauma(){
        trauma_lElbow_fracture = true;
        trauma_modificator_DMG = trauma_modificator_DMG - 2;
    }

    public void lClavicle_fracture_trauma(){
        trauma_lClavicle_fracture = true;
        trauma_modificator_DMG = trauma_modificator_DMG - 3;
    }

    public void rKnee_fracture_trauma(){
        trauma_rKnee_fracture = true;
        rLeg_trauma_armor_modifier = rLeg_trauma_armor_modifier - 2;
    }

    public void rFoot_fracture_trauma(){
        trauma_rFoot_fracture = true;
        rLeg_trauma_armor_modifier = rLeg_trauma_armor_modifier - 1;
    }

    public void lKnee_fracture_trauma(){
        trauma_lKnee_fracture = true;
        lLeg_trauma_armor_modifier = lLeg_trauma_armor_modifier - 2;
    }

    public void lFoot_fracture_trauma(){
        trauma_lFoot_fracture = true;
        lLeg_trauma_armor_modifier = lLeg_trauma_armor_modifier - 1;
    }

}


