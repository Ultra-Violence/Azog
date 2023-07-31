using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Deer_survival_check : MonoBehaviour
{

    public bool deer0_quest_end = false;
    public static bool static_deer0_quest_end = false;

    public HeroPeaceSkills HeroPeaceSkills;
    public LvlUp LvlUp;
    public InventoryConvas InventoryConvas;

    public GameObject Deer;

    public GameObject deer_survival_check_HUD;
    public GameObject deer_survival_check_complited_HUD;
    public GameObject deer_survival_check_failed_HUD;

    private void Awake() {
        deer0_quest_end = static_deer0_quest_end;
    }

    private void Update() {
        static_deer0_quest_end = deer0_quest_end;

        if(deer0_quest_end == true & SceneManager.GetActiveScene().name == "SampleScene")
            Deer.SetActive(false);
    }

    public void survival_check(){
        System.Random random_d20 = new System.Random();
        int random_d20_dice = random_d20.Next(21);

        int result = HeroPeaceSkills.survival + random_d20_dice;

        if(result > 8){
            deer_survival_check_complited_HUD.SetActive(true);
            LvlUp.exp = LvlUp.exp + 100;
            deer_survival_check_HUD.SetActive(false);
        }
        else{ 
            deer_survival_check_failed_HUD.SetActive(true);
            LvlUp.exp = LvlUp.exp + 50;
            deer_survival_check_HUD.SetActive(false);
        }
    }

    public void go_past(){
        deer_survival_check_HUD.SetActive(false);
        deer_survival_check_complited_HUD.SetActive(false);
        deer_survival_check_failed_HUD.SetActive(false);
    }

    public void leave_wiht_nothing(){
        deer_survival_check_HUD.SetActive(false);
        deer_survival_check_complited_HUD.SetActive(false);
        deer_survival_check_failed_HUD.SetActive(false);
        deer0_quest_end = true;
    }

        public void take_food_button(){
        InventoryConvas.Add_food_inv_list("Food");
        deer_survival_check_HUD.SetActive(false);
        deer_survival_check_complited_HUD.SetActive(false);
        deer_survival_check_failed_HUD.SetActive(false);
        deer0_quest_end = true;
    }
}