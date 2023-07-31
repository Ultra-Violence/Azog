using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Button Start_again;
    public GameObject Hero;

    public void starnAgain(){
        SceneManager.LoadScene("Menu");
        Hero.GetComponent<HeroAttack>().player_place.position = new Vector3 (0.5f, 0.5f, 0);  // повернення на сталу позицію ))))))

        Hero.GetComponent<HeroStats>().strength = 1;
        Hero.GetComponent<HeroStats>().agility = 1;
        Hero.GetComponent<HeroStats>().intelligence = 1;

        Hero.GetComponent<HeroStats>().HP_head_rn = 20f;
        Hero.GetComponent<HeroStats>().HP_body_rn = 80f;
        Hero.GetComponent<HeroStats>().HP_rArm_rn = 40f;
        Hero.GetComponent<HeroStats>().HP_lArm_rn = 40f;
        Hero.GetComponent<HeroStats>().HP_rLeg_rn = 50f;
        Hero.GetComponent<HeroStats>().HP_lLeg_rn = 50f;
        Hero.GetComponent<HeroStats>().HP_head_max = 20f;
        Hero.GetComponent<HeroStats>().HP_body_max = 80f;
        Hero.GetComponent<HeroStats>().HP_rArm_max = 40f;
        Hero.GetComponent<HeroStats>().HP_lArm_max = 40f;
        Hero.GetComponent<HeroStats>().HP_rLeg_max = 50f;
        Hero.GetComponent<HeroStats>().HP_lLeg_max = 50f;
        Hero.GetComponent<HeroStats>().exp_modificator = 1;
        Hero.GetComponent<HeroStats>().minus_enemy_armor = 0;
        Hero.GetComponent<HeroStats>().plus_armor = 0;

        Hero.GetComponent<HeroStats>().trauma_concussion = false;
        Hero.GetComponent<HeroStats>().trauma_pierced_skull = false;
        Hero.GetComponent<HeroStats>().trauma_damaged_left_lung = false;
        Hero.GetComponent<HeroStats>().trauma_damaged_right_lung = false;
        Hero.GetComponent<HeroStats>().trauma_hit_heart = false;
        Hero.GetComponent<HeroStats>().trauma_severed_rThumb = false;
        Hero.GetComponent<HeroStats>().trauma_severed_rIndex = false;
        Hero.GetComponent<HeroStats>().trauma_severed_rMiddle = false;
        Hero.GetComponent<HeroStats>().trauma_severed_rRing = false;
        Hero.GetComponent<HeroStats>().trauma_severed_rLittle = false;
        Hero.GetComponent<HeroStats>().trauma_rHand_fracture = false;
        Hero.GetComponent<HeroStats>().trauma_rElbow_fracture = false;
        Hero.GetComponent<HeroStats>().trauma_rClavicle_fracture = false;
        Hero.GetComponent<HeroStats>().trauma_severed_lThumb = false;
        Hero.GetComponent<HeroStats>().trauma_severed_lIndex = false;
        Hero.GetComponent<HeroStats>().trauma_severed_lMiddle = false;
        Hero.GetComponent<HeroStats>().trauma_severed_lRing = false;
        Hero.GetComponent<HeroStats>().trauma_severed_lLittle = false;
        Hero.GetComponent<HeroStats>().trauma_lHand_fracture = false;
        Hero.GetComponent<HeroStats>().trauma_lElbow_fracture = false;
        Hero.GetComponent<HeroStats>().trauma_lClavicle_fracture = false; 
        Hero.GetComponent<HeroStats>().trauma_rKnee_fracture = false;      
        Hero.GetComponent<HeroStats>().trauma_rFoot_fracture = false;  
        Hero.GetComponent<HeroStats>().trauma_lKnee_fracture = false;      
        Hero.GetComponent<HeroStats>().trauma_lFoot_fracture = false;

        Hero.GetComponent<HeroStats>().head_trauma_armor_modifier = 0; 
        Hero.GetComponent<HeroStats>().body_trauma_armor_modifier = 0; 
        Hero.GetComponent<HeroStats>().rArm_trauma_armor_modifier = 0; 
        Hero.GetComponent<HeroStats>().lArm_trauma_armor_modifier = 0; 
        Hero.GetComponent<HeroStats>().rLeg_trauma_armor_modifier = 0; 
        Hero.GetComponent<HeroStats>().lLeg_trauma_armor_modifier = 0; 
        Hero.GetComponent<HeroStats>().trauma_modificator_DMG = 0; 

        Hero.GetComponent<LvlUp>().exp = 0;
        Hero.GetComponent<LvlUp>().lvl_hero = 0;
        Hero.GetComponent<LvlUp>().lvlPoint = 0;

        Hero.GetComponent<HeroPeaceSkills>().plus_str_peace_skills = 0;
        Hero.GetComponent<HeroPeaceSkills>().plus_agl_peace_skills = 0;
        Hero.GetComponent<HeroPeaceSkills>().plus_int_peace_skills = 0;

        Hero.GetComponent<HeroEffects>().x3_head_damage = false;
        Hero.GetComponent<HeroEffects>().x1_5_body_damage = false;

        Hero.GetComponent<Goblin_seller_quest>().quest_completed = false;
        Hero.GetComponent<Goblin_seller_quest>().quest_taken = false;
        Hero.GetComponent<Hunter_medicine_quest>().end_Hunter_quest = false;
        Hero.GetComponent<Altar_religion_check>().altar_quest_end = false;
        Hero.GetComponent<Altar_religion_check>().looking_for_food_gift = false;
        Hero.GetComponent<Napis_history_check>().napis_quest_end = false;
        Hero.GetComponent<Deer_survival_check>().deer0_quest_end = false;
        Hero.GetComponent<Deer1_survival_check>().deer1_quest_end = false;
        Hero.GetComponent<Deer2_survival_check>().deer2_quest_end = false;



        Hero.GetComponent<chest1>().bool_chest = false;
        Hero.GetComponent<chest2>().bool_chest = false;
        Hero.GetComponent<chest3>().bool_chest = false;

        Hero.GetComponent<HeroStats>().item_armor_head = 0f;
        Hero.GetComponent<Items>().Helm_of_yura = false;
    
        Hero.GetComponent<Items>().Armor_of_yura = false;
        Hero.GetComponent<HeroStats>().item_armor_body = 0f;

        Hero.GetComponent<Items>().Shoulder_of_yura_right = false;
        Hero.GetComponent<HeroStats>().item_armor_rArm = 0f;

        Hero.GetComponent<Items>().Shoulder_of_yura_left = false;
        Hero.GetComponent<HeroStats>().item_armor_lArm = 0f;

        Hero.GetComponent<Items>().Boot_of_yura_right = false;
        Hero.GetComponent<HeroStats>().item_armor_rLeg = 0f;

        Hero.GetComponent<Items>().Boot_of_yura_left = false;
        Hero.GetComponent<HeroStats>().item_armor_lLeg = 0f;

        Hero.GetComponent<Items>().fists = true;
        Hero.GetComponent<Items>().Stick_of_yura = false;        
        Hero.GetComponent<Items>().Spear_of_yura = false;
        Hero.GetComponent<Items>().Staff_of_yura = false;
        
        Hero.GetComponent<HeroStats>().item_DMG = 0f;

        Hero.GetComponent<Items>().Shield_of_yura = false;

        Hero.GetComponent<Enemys>().goblin_quest_target = true; 
        Hero.GetComponent<Enemys>().goblin0 = true; 
        Hero.GetComponent<Enemys>().goblin1 = true; 
        Hero.GetComponent<Enemys>().goblin2 = true;
        Hero.GetComponent<Enemys>().goblin3 = true;
        Hero.GetComponent<Enemys>().dark_goblin0 = true;    

        Hero.GetComponent<SlotBool>().empty = true;
        Hero.GetComponent<SlotBool>().food = 0;
        Hero.GetComponent<SlotBool>().foodBool = false;
        Hero.GetComponent<SlotBool>().eqp_head = false;
        Hero.GetComponent<SlotBool>().eqp_body = false;
        Hero.GetComponent<SlotBool>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool>().eqp_lArm_wpn = false;   

        Hero.GetComponent<SlotBool1>().empty = true;
        Hero.GetComponent<SlotBool1>().food = 0;
        Hero.GetComponent<SlotBool1>().foodBool = false;
        Hero.GetComponent<SlotBool1>().eqp_head = false;
        Hero.GetComponent<SlotBool1>().eqp_body = false;
        Hero.GetComponent<SlotBool1>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool1>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool1>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool1>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool1>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool1>().eqp_lArm_wpn = false; 

        Hero.GetComponent<SlotBool2>().empty = true;
        Hero.GetComponent<SlotBool2>().food = 0;
        Hero.GetComponent<SlotBool2>().foodBool = false;
        Hero.GetComponent<SlotBool2>().eqp_head = false;
        Hero.GetComponent<SlotBool2>().eqp_body = false;
        Hero.GetComponent<SlotBool2>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool2>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool2>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool2>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool2>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool2>().eqp_lArm_wpn = false;  

        Hero.GetComponent<SlotBool3>().empty = true;
        Hero.GetComponent<SlotBool3>().food = 0;
        Hero.GetComponent<SlotBool3>().foodBool = false;
        Hero.GetComponent<SlotBool3>().eqp_head = false;
        Hero.GetComponent<SlotBool3>().eqp_body = false;
        Hero.GetComponent<SlotBool3>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool3>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool3>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool3>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool3>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool3>().eqp_lArm_wpn = false;

        Hero.GetComponent<SlotBool4>().empty = true;
        Hero.GetComponent<SlotBool4>().food = 0;
        Hero.GetComponent<SlotBool4>().foodBool = false;
        Hero.GetComponent<SlotBool4>().eqp_head = false;
        Hero.GetComponent<SlotBool4>().eqp_body = false;
        Hero.GetComponent<SlotBool4>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool4>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool4>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool4>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool4>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool4>().eqp_lArm_wpn = false; 

        Hero.GetComponent<SlotBool5>().empty = true;
        Hero.GetComponent<SlotBool5>().food = 0;
        Hero.GetComponent<SlotBool5>().foodBool = false;
        Hero.GetComponent<SlotBool5>().eqp_head = false;
        Hero.GetComponent<SlotBool5>().eqp_body = false;
        Hero.GetComponent<SlotBool5>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool5>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool5>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool5>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool5>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool5>().eqp_lArm_wpn = false; 

        Hero.GetComponent<SlotBool6>().empty = true;
        Hero.GetComponent<SlotBool6>().food = 0;
        Hero.GetComponent<SlotBool6>().foodBool = false;
        Hero.GetComponent<SlotBool6>().eqp_head = false;
        Hero.GetComponent<SlotBool6>().eqp_body = false;
        Hero.GetComponent<SlotBool6>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool6>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool6>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool6>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool6>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool6>().eqp_lArm_wpn = false; 

        Hero.GetComponent<SlotBool7>().empty = true;
        Hero.GetComponent<SlotBool7>().food = 0;
        Hero.GetComponent<SlotBool7>().foodBool = false;
        Hero.GetComponent<SlotBool7>().eqp_head = false;
        Hero.GetComponent<SlotBool7>().eqp_body = false;
        Hero.GetComponent<SlotBool7>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool7>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool7>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool7>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool7>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool7>().eqp_lArm_wpn = false; 

        Hero.GetComponent<SlotBool8>().empty = true;
        Hero.GetComponent<SlotBool8>().food = 0;
        Hero.GetComponent<SlotBool8>().foodBool = false;
        Hero.GetComponent<SlotBool8>().eqp_head = false;
        Hero.GetComponent<SlotBool8>().eqp_body = false;
        Hero.GetComponent<SlotBool8>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool8>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool8>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool8>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool8>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool8>().eqp_lArm_wpn = false; 

        Hero.GetComponent<SlotBool9>().empty = true;
        Hero.GetComponent<SlotBool9>().food = 0;
        Hero.GetComponent<SlotBool9>().foodBool = false;
        Hero.GetComponent<SlotBool9>().eqp_head = false;
        Hero.GetComponent<SlotBool9>().eqp_body = false;
        Hero.GetComponent<SlotBool9>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool9>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool9>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool9>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool9>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool9>().eqp_lArm_wpn = false;  
        
        Hero.GetComponent<SlotBool10>().empty = true;
        Hero.GetComponent<SlotBool10>().food = 0;
        Hero.GetComponent<SlotBool10>().foodBool = false;
        Hero.GetComponent<SlotBool10>().eqp_head = false;
        Hero.GetComponent<SlotBool10>().eqp_body = false;
        Hero.GetComponent<SlotBool10>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool10>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool10>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool10>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool10>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool10>().eqp_lArm_wpn = false; 
    }

    public void play_button(){
        SceneManager.LoadScene("SampleScene");

        Hero.GetComponent<HeroAttack>().player_place.position = new Vector3 (0.5f, 0.5f, 0);  // повернення на сталу позицію ))))))

        Hero.GetComponent<HeroStats>().strength = 1;
        Hero.GetComponent<HeroStats>().agility = 1;
        Hero.GetComponent<HeroStats>().intelligence = 1;

        Hero.GetComponent<HeroStats>().HP_head_rn = 20f;
        Hero.GetComponent<HeroStats>().HP_body_rn = 80f;
        Hero.GetComponent<HeroStats>().HP_rArm_rn = 40f;
        Hero.GetComponent<HeroStats>().HP_lArm_rn = 40f;
        Hero.GetComponent<HeroStats>().HP_rLeg_rn = 50f;
        Hero.GetComponent<HeroStats>().HP_lLeg_rn = 50f;
        Hero.GetComponent<HeroStats>().HP_head_max = 20f;
        Hero.GetComponent<HeroStats>().HP_body_max = 80f;
        Hero.GetComponent<HeroStats>().HP_rArm_max = 40f;
        Hero.GetComponent<HeroStats>().HP_lArm_max = 40f;
        Hero.GetComponent<HeroStats>().HP_rLeg_max = 50f;
        Hero.GetComponent<HeroStats>().HP_lLeg_max = 50f;
        Hero.GetComponent<HeroStats>().exp_modificator = 1;
        Hero.GetComponent<HeroStats>().minus_enemy_armor = 0;
        Hero.GetComponent<HeroStats>().plus_armor = 0;

        Hero.GetComponent<HeroStats>().trauma_concussion = false;
        Hero.GetComponent<HeroStats>().trauma_pierced_skull = false;
        Hero.GetComponent<HeroStats>().trauma_damaged_left_lung = false;
        Hero.GetComponent<HeroStats>().trauma_damaged_right_lung = false;
        Hero.GetComponent<HeroStats>().trauma_hit_heart = false;
        Hero.GetComponent<HeroStats>().trauma_severed_rThumb = false;
        Hero.GetComponent<HeroStats>().trauma_severed_rIndex = false;
        Hero.GetComponent<HeroStats>().trauma_severed_rMiddle = false;
        Hero.GetComponent<HeroStats>().trauma_severed_rRing = false;
        Hero.GetComponent<HeroStats>().trauma_severed_rLittle = false;
        Hero.GetComponent<HeroStats>().trauma_rHand_fracture = false;
        Hero.GetComponent<HeroStats>().trauma_rElbow_fracture = false;
        Hero.GetComponent<HeroStats>().trauma_rClavicle_fracture = false;
        Hero.GetComponent<HeroStats>().trauma_severed_lThumb = false;
        Hero.GetComponent<HeroStats>().trauma_severed_lIndex = false;
        Hero.GetComponent<HeroStats>().trauma_severed_lMiddle = false;
        Hero.GetComponent<HeroStats>().trauma_severed_lRing = false;
        Hero.GetComponent<HeroStats>().trauma_severed_lLittle = false;
        Hero.GetComponent<HeroStats>().trauma_lHand_fracture = false;
        Hero.GetComponent<HeroStats>().trauma_lElbow_fracture = false;
        Hero.GetComponent<HeroStats>().trauma_lClavicle_fracture = false; 
        Hero.GetComponent<HeroStats>().trauma_rKnee_fracture = false;      
        Hero.GetComponent<HeroStats>().trauma_rFoot_fracture = false;  
        Hero.GetComponent<HeroStats>().trauma_lKnee_fracture = false;      
        Hero.GetComponent<HeroStats>().trauma_lFoot_fracture = false;

        Hero.GetComponent<HeroStats>().head_trauma_armor_modifier = 0; 
        Hero.GetComponent<HeroStats>().body_trauma_armor_modifier = 0; 
        Hero.GetComponent<HeroStats>().rArm_trauma_armor_modifier = 0; 
        Hero.GetComponent<HeroStats>().lArm_trauma_armor_modifier = 0; 
        Hero.GetComponent<HeroStats>().rLeg_trauma_armor_modifier = 0; 
        Hero.GetComponent<HeroStats>().lLeg_trauma_armor_modifier = 0; 
        Hero.GetComponent<HeroStats>().trauma_modificator_DMG = 0; 

        Hero.GetComponent<LvlUp>().exp = 0;
        Hero.GetComponent<LvlUp>().lvl_hero = 0;
        Hero.GetComponent<LvlUp>().lvlPoint = 0;

        Hero.GetComponent<HeroPeaceSkills>().plus_str_peace_skills = 0;
        Hero.GetComponent<HeroPeaceSkills>().plus_agl_peace_skills = 0;
        Hero.GetComponent<HeroPeaceSkills>().plus_int_peace_skills = 0;

        Hero.GetComponent<HeroEffects>().x3_head_damage = false;
        Hero.GetComponent<HeroEffects>().x1_5_body_damage = false;

        Hero.GetComponent<Goblin_seller_quest>().quest_completed = false;
        Hero.GetComponent<Goblin_seller_quest>().quest_taken = false;
        Hero.GetComponent<Hunter_medicine_quest>().end_Hunter_quest = false;
        Hero.GetComponent<Altar_religion_check>().altar_quest_end = false;
        Hero.GetComponent<Altar_religion_check>().looking_for_food_gift = false;
        Hero.GetComponent<Napis_history_check>().napis_quest_end = false;
        Hero.GetComponent<Deer_survival_check>().deer0_quest_end = false;
        Hero.GetComponent<Deer1_survival_check>().deer1_quest_end = false;
        Hero.GetComponent<Deer2_survival_check>().deer2_quest_end = false;



        Hero.GetComponent<chest1>().bool_chest = false;
        Hero.GetComponent<chest2>().bool_chest = false;
        Hero.GetComponent<chest3>().bool_chest = false;

        Hero.GetComponent<HeroStats>().item_armor_head = 0f;
        Hero.GetComponent<Items>().Helm_of_yura = false;
    
        Hero.GetComponent<Items>().Armor_of_yura = false;
        Hero.GetComponent<HeroStats>().item_armor_body = 0f;

        Hero.GetComponent<Items>().Shoulder_of_yura_right = false;
        Hero.GetComponent<HeroStats>().item_armor_rArm = 0f;

        Hero.GetComponent<Items>().Shoulder_of_yura_left = false;
        Hero.GetComponent<HeroStats>().item_armor_lArm = 0f;

        Hero.GetComponent<Items>().Boot_of_yura_right = false;
        Hero.GetComponent<HeroStats>().item_armor_rLeg = 0f;

        Hero.GetComponent<Items>().Boot_of_yura_left = false;
        Hero.GetComponent<HeroStats>().item_armor_lLeg = 0f;

        Hero.GetComponent<Items>().fists = true;
        Hero.GetComponent<Items>().Stick_of_yura = false;        
        Hero.GetComponent<Items>().Spear_of_yura = false;
        Hero.GetComponent<Items>().Staff_of_yura = false;
        
        Hero.GetComponent<HeroStats>().item_DMG = 0f;

        Hero.GetComponent<Items>().Shield_of_yura = false;

        Hero.GetComponent<Enemys>().goblin_quest_target = true; 
        Hero.GetComponent<Enemys>().goblin0 = true; 
        Hero.GetComponent<Enemys>().goblin1 = true; 
        Hero.GetComponent<Enemys>().goblin2 = true;
        Hero.GetComponent<Enemys>().goblin3 = true;
        Hero.GetComponent<Enemys>().dark_goblin0 = true;    

        Hero.GetComponent<SlotBool>().empty = true;
        Hero.GetComponent<SlotBool>().food = 0;
        Hero.GetComponent<SlotBool>().foodBool = false;
        Hero.GetComponent<SlotBool>().eqp_head = false;
        Hero.GetComponent<SlotBool>().eqp_body = false;
        Hero.GetComponent<SlotBool>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool>().eqp_lArm_wpn = false;   

        Hero.GetComponent<SlotBool1>().empty = true;
        Hero.GetComponent<SlotBool1>().food = 0;
        Hero.GetComponent<SlotBool1>().foodBool = false;
        Hero.GetComponent<SlotBool1>().eqp_head = false;
        Hero.GetComponent<SlotBool1>().eqp_body = false;
        Hero.GetComponent<SlotBool1>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool1>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool1>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool1>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool1>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool1>().eqp_lArm_wpn = false; 

        Hero.GetComponent<SlotBool2>().empty = true;
        Hero.GetComponent<SlotBool2>().food = 0;
        Hero.GetComponent<SlotBool2>().foodBool = false;
        Hero.GetComponent<SlotBool2>().eqp_head = false;
        Hero.GetComponent<SlotBool2>().eqp_body = false;
        Hero.GetComponent<SlotBool2>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool2>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool2>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool2>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool2>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool2>().eqp_lArm_wpn = false;  

        Hero.GetComponent<SlotBool3>().empty = true;
        Hero.GetComponent<SlotBool3>().food = 0;
        Hero.GetComponent<SlotBool3>().foodBool = false;
        Hero.GetComponent<SlotBool3>().eqp_head = false;
        Hero.GetComponent<SlotBool3>().eqp_body = false;
        Hero.GetComponent<SlotBool3>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool3>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool3>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool3>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool3>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool3>().eqp_lArm_wpn = false;

        Hero.GetComponent<SlotBool4>().empty = true;
        Hero.GetComponent<SlotBool4>().food = 0;
        Hero.GetComponent<SlotBool4>().foodBool = false;
        Hero.GetComponent<SlotBool4>().eqp_head = false;
        Hero.GetComponent<SlotBool4>().eqp_body = false;
        Hero.GetComponent<SlotBool4>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool4>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool4>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool4>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool4>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool4>().eqp_lArm_wpn = false; 

        Hero.GetComponent<SlotBool5>().empty = true;
        Hero.GetComponent<SlotBool5>().food = 0;
        Hero.GetComponent<SlotBool5>().foodBool = false;
        Hero.GetComponent<SlotBool5>().eqp_head = false;
        Hero.GetComponent<SlotBool5>().eqp_body = false;
        Hero.GetComponent<SlotBool5>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool5>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool5>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool5>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool5>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool5>().eqp_lArm_wpn = false; 

        Hero.GetComponent<SlotBool6>().empty = true;
        Hero.GetComponent<SlotBool6>().food = 0;
        Hero.GetComponent<SlotBool6>().foodBool = false;
        Hero.GetComponent<SlotBool6>().eqp_head = false;
        Hero.GetComponent<SlotBool6>().eqp_body = false;
        Hero.GetComponent<SlotBool6>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool6>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool6>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool6>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool6>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool6>().eqp_lArm_wpn = false; 

        Hero.GetComponent<SlotBool7>().empty = true;
        Hero.GetComponent<SlotBool7>().food = 0;
        Hero.GetComponent<SlotBool7>().foodBool = false;
        Hero.GetComponent<SlotBool7>().eqp_head = false;
        Hero.GetComponent<SlotBool7>().eqp_body = false;
        Hero.GetComponent<SlotBool7>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool7>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool7>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool7>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool7>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool7>().eqp_lArm_wpn = false; 

        Hero.GetComponent<SlotBool8>().empty = true;
        Hero.GetComponent<SlotBool8>().food = 0;
        Hero.GetComponent<SlotBool8>().foodBool = false;
        Hero.GetComponent<SlotBool8>().eqp_head = false;
        Hero.GetComponent<SlotBool8>().eqp_body = false;
        Hero.GetComponent<SlotBool8>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool8>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool8>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool8>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool8>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool8>().eqp_lArm_wpn = false; 

        Hero.GetComponent<SlotBool9>().empty = true;
        Hero.GetComponent<SlotBool9>().food = 0;
        Hero.GetComponent<SlotBool9>().foodBool = false;
        Hero.GetComponent<SlotBool9>().eqp_head = false;
        Hero.GetComponent<SlotBool9>().eqp_body = false;
        Hero.GetComponent<SlotBool9>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool9>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool9>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool9>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool9>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool9>().eqp_lArm_wpn = false;  
        
        Hero.GetComponent<SlotBool10>().empty = true;
        Hero.GetComponent<SlotBool10>().food = 0;
        Hero.GetComponent<SlotBool10>().foodBool = false;
        Hero.GetComponent<SlotBool10>().eqp_head = false;
        Hero.GetComponent<SlotBool10>().eqp_body = false;
        Hero.GetComponent<SlotBool10>().eqp_rArm = false;   
        Hero.GetComponent<SlotBool10>().eqp_lArm = false;   
        Hero.GetComponent<SlotBool10>().eqp_rLeg = false;  
        Hero.GetComponent<SlotBool10>().eqp_lLeg = false;
        Hero.GetComponent<SlotBool10>().eqp_rArm_wpn = false;
        Hero.GetComponent<SlotBool10>().eqp_lArm_wpn = false; 
    }


}
