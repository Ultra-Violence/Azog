using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Altar_religion_check : MonoBehaviour
{
    public SlotBool slot1;
    public SlotBool1 slot2;
    public SlotBool2 slot3;
    public SlotBool3 slot4;
    public SlotBool4 slot5;
    public SlotBool5 slot6;
    public SlotBool6 slot7;
    public SlotBool7 slot8;
    public SlotBool8 slot9;
    public SlotBool9 slot10;
    public SlotBool10 slot11;

    public Text gift_button_text;
 
    public HeroPeaceSkills HeroPeaceSkills;
    public LvlUp LvlUp;

    public restScript restScript;
    public HeroStats Hero;

    public bool altar_quest_end = false;
    public static bool static_altar_quest_end = false;

    public bool looking_for_food_gift = false;
    public static bool static_looking_for_food_gift = false;

    public GameObject altar_religion_quest_HUD;
    public GameObject altar_religion_quest_complited_HUD;
    public GameObject altar_religion_quest_failed_HUD;
    public GameObject altar_religion_quest_gift_HUD;

    private void Awake() {
        altar_quest_end = static_altar_quest_end;
        looking_for_food_gift = static_looking_for_food_gift;
    }

    private void Update() {
        static_altar_quest_end = altar_quest_end;
        static_looking_for_food_gift = looking_for_food_gift;
        if(SceneManager.GetActiveScene().name == "SampleScene"){
            if(altar_religion_quest_complited_HUD.activeInHierarchy == true & restScript.tent_charge < 1){
                gift_button_text.text = "You don't have enough food for gift";
            }
            else if(altar_religion_quest_complited_HUD.activeInHierarchy == true & restScript.tent_charge > 0){
                gift_button_text.text = "Present a gift";
            }
            }

    }

    public void religion_check(){
        System.Random random_d20 = new System.Random();
        int random_d20_dice = random_d20.Next(21);

        int result = HeroPeaceSkills.religion + random_d20_dice;

        if(result > 10){
            altar_religion_quest_complited_HUD.SetActive(true);
            LvlUp.exp = LvlUp.exp + 200;
            altar_religion_quest_HUD.SetActive(false);
        }
        else{ 
            altar_religion_quest_failed_HUD.SetActive(true);
            LvlUp.exp = LvlUp.exp + 100;
            altar_religion_quest_HUD.SetActive(false);
        }
    }

    public void move_away(){
        altar_religion_quest_HUD.SetActive(false);
        altar_religion_quest_complited_HUD.SetActive(false);
        altar_religion_quest_failed_HUD.SetActive(false);
        altar_religion_quest_gift_HUD.SetActive(false);
        altar_quest_end = true;
    }

    public void gift_button(){
        if(restScript.tent_charge > 0){
            altar_religion_quest_gift_HUD.SetActive(true);
            altar_religion_quest_complited_HUD.SetActive(false);
            looking_for_food_gift = false;
            LvlUp.exp = LvlUp.exp + 100;
            Hero.strength = Hero.strength + 1;
            Hero.agility = Hero.agility + 1;
            Hero.intelligence = Hero.intelligence + 1;

            if(slot1.foodBool == true){
                    slot1.food -= 1;
                }
                else if(slot2.foodBool == true){
                    slot2.food -= 1;
                }
                else if(slot3.foodBool == true){
                    slot3.food -= 1;
                }
                else if(slot4.foodBool == true){
                    slot4.food -= 1;
                }
                else if(slot5.foodBool == true){
                    slot5.food -= 1;
                } 
                else if(slot6.foodBool == true){
                    slot6.food -= 1;
                } 
                else if(slot7.foodBool == true){
                    slot7.food -= 1;
                }  
                else if(slot8.foodBool == true){
                    slot8.food -= 1;
                } 
                else if(slot9.foodBool == true){
                    slot9.food -= 1;
                } 
                else if(slot10.foodBool == true){
                    slot10.food -= 1;
                } 
                else if(slot11.foodBool == true){
                    slot11.food -= 1;
                }    
                }
            else{    
                looking_for_food_gift = true;
                }

    }

    public void ignore_button(){
        altar_religion_quest_HUD.SetActive(false);
    }
 
}
