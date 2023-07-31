using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class restScript : MonoBehaviour
{

    public HeroStats Hero;

    public bool rest = false;
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
 
    public GameObject tent;

    public int tent_charge = 0;

    public void rest_on(){

        if(rest == false & tent_charge >= 1 ){
            rest = true;
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
        else 
            rest = false;
        
    }

    public void FixedUpdate() {
        tent_charge = slot1.food + slot2.food + slot3.food + slot4.food + slot5.food + slot6.food + slot7.food + slot8.food + slot9.food + slot10.food + slot11.food;                                 //список слотів
        if(rest == true){
            Time.timeScale = 3;
            tent.SetActive(true);
            Hero.HP_head_rn = Hero.HP_head_rn + ((Hero.HP_head_max*0.1f) * Time.deltaTime);   
            Hero.HP_body_rn = Hero.HP_body_rn + ((Hero.HP_body_max*0.1f) * Time.deltaTime);
            Hero.HP_lArm_rn = Hero.HP_lArm_rn + ((Hero.HP_rArm_max*0.1f) * Time.deltaTime);
            Hero.HP_rArm_rn = Hero.HP_rArm_rn + ((Hero.HP_lArm_max*0.1f) * Time.deltaTime);
            Hero.HP_lLeg_rn = Hero.HP_lLeg_rn + ((Hero.HP_rLeg_max*0.1f) * Time.deltaTime);
            Hero.HP_rLeg_rn = Hero.HP_rLeg_rn + ((Hero.HP_lLeg_max*0.1f) * Time.deltaTime);
            
        }
        }
    
    private void Update() {
       if(rest == false){
            Time.timeScale = 1;
            tent.SetActive(false); 
        }

        if(Input.anyKeyDown){
            rest = false;
        } 
    }
        

    
}
