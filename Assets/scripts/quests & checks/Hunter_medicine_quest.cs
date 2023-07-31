using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Hunter_medicine_quest : MonoBehaviour
{
    public bool end_Hunter_quest = false;
    public static bool static_end_Hunter_quest = false;

    public HeroPeaceSkills HeroPeaceSkills;
    public LvlUp LvlUp;
    public InventoryConvas InventoryConvas;

    public GameObject Hunter;

    public GameObject hunter_medicine_quest_HUD;
    public GameObject hunter_medicine_quest_complited_HUD;
    public GameObject hunter_medicine_quest_failed_HUD;
    public GameObject hunter_medicine_quest_ignore_HUD;

    private void Awake() {
        end_Hunter_quest = static_end_Hunter_quest;
    }

    private void Update() {
        static_end_Hunter_quest = end_Hunter_quest;


        if(end_Hunter_quest == true & SceneManager.GetActiveScene().name == "SampleScene")
            Hunter.SetActive(false);
    }

    public void medicine_check(){
        System.Random random_d20 = new System.Random();
        int random_d20_dice = random_d20.Next(21);

        int result = HeroPeaceSkills.medicine + random_d20_dice;

        if(result > 8){
            hunter_medicine_quest_complited_HUD.SetActive(true);
            LvlUp.exp = LvlUp.exp + 200;
            hunter_medicine_quest_HUD.SetActive(false);
        }
        else{ 
            hunter_medicine_quest_failed_HUD.SetActive(true);
            LvlUp.exp = LvlUp.exp + 150;
            hunter_medicine_quest_HUD.SetActive(false);
        }
    }

    public void ignore_button(){
        hunter_medicine_quest_ignore_HUD.SetActive(true);
        hunter_medicine_quest_HUD.SetActive(false);
    }

    public void take_food_button(){
        InventoryConvas.Add_food_inv_list("Food");
        hunter_medicine_quest_HUD.SetActive(false);
        hunter_medicine_quest_complited_HUD.SetActive(false);
        hunter_medicine_quest_failed_HUD.SetActive(false);
        hunter_medicine_quest_ignore_HUD.SetActive(false);
        end_Hunter_quest = true;
    }

    
}
