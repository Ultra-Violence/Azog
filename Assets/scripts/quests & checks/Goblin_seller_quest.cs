using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goblin_seller_quest : MonoBehaviour
{
    public bool quest_taken = false;
    public static bool static_quest_taken = false;
    public bool quest_completed = false;
    public static bool static_quest_completed = false;

    public GameObject goblin_seller_quest_HUD;
    public GameObject goblin_seller_quest_completed_HUD;
    public GameObject goblin_seller_quest_mark;
    public GameObject goblin_seller_quest_quest_mark;

    public InventoryConvas InventoryConvas;

    private void Awake() {
        quest_completed = static_quest_completed;
        quest_taken = static_quest_taken;
    }

    public void questAgree_button(){
        quest_taken = true;
        goblin_seller_quest_HUD.SetActive(false);   
        //goblin_seller_quest_mark.SetActive(false);
    }

    public void questNotAgree_button(){
        goblin_seller_quest_HUD.SetActive(false);
        
    }

    public void questRewardStick_button(){
        InventoryConvas.Add_item_inv_list("Stick_of_yura");
        goblin_seller_quest_completed_HUD.SetActive(false);
        quest_completed = false;
        
    }

    public void questRewardSpear_button(){
        InventoryConvas.Add_item_inv_list("Spear_of_yura");
        goblin_seller_quest_completed_HUD.SetActive(false);
        quest_completed = false;
        
    }

    public void questRewardStaff_button(){
        InventoryConvas.Add_item_inv_list("Staff_of_yura");
        goblin_seller_quest_completed_HUD.SetActive(false);
        quest_completed = false;
        
    }

    private void Update() {
        if(SceneManager.GetActiveScene().name == "SampleScene"){
            if(quest_taken == true)
                goblin_seller_quest_mark.SetActive(false);
        
            if(quest_completed == true & quest_taken == true)
                goblin_seller_quest_quest_mark.SetActive(true);
            else if(quest_completed == false & quest_taken == true) 
                goblin_seller_quest_quest_mark.SetActive(false);
        }

        static_quest_completed = quest_completed;
        static_quest_taken = quest_taken;
    }
}
