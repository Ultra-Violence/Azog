using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlPoint : MonoBehaviour
{
    public GameObject lvlUpMenu;
    public GameObject lvlUpButton;
    public GameObject Hero;

    public Button plus_one_str_button;
    public Button plus_one_agl_button;
    public Button plus_one_int_button;

    static private int charge_max_HP = 0;
    static private int charge_armor = 0;
    static private int charge_exp_modificator = 0;
    static private int charge_minus_enemy_armor = 0;
    static private int charge_plus_str_peace_skills = 0;
    static private int charge_plus_agl_peace_skills = 0;
    static private int charge_plus_int_peace_skills = 0;

    public void lvlupButton(){
        lvlUpMenu.SetActive(true);
        lvlUpButton.SetActive(false);

    }

    public void esc_button(){
        lvlUpMenu.SetActive(false);
    }

    public void plus_one_str(){
        if(Hero.GetComponent<LvlUp>().lvlPoint > 0){
            Hero.GetComponent<LvlUp>().lvlPoint--;
            Hero.GetComponent<HeroStats>().strength++;
        }
    }

    public void plus_max_HP(){
        if(Hero.GetComponent<LvlUp>().lvlPoint > 0 & charge_max_HP <= 2){
            charge_max_HP++;
            Hero.GetComponent<LvlUp>().lvlPoint--;
            Hero.GetComponent<HeroStats>().HP_head_max = Hero.GetComponent<HeroStats>().HP_head_max * 1.2f;
            Hero.GetComponent<HeroStats>().HP_body_max = Hero.GetComponent<HeroStats>().HP_body_max * 1.2f;
            Hero.GetComponent<HeroStats>().HP_rArm_max = Hero.GetComponent<HeroStats>().HP_rArm_max * 1.2f;
            Hero.GetComponent<HeroStats>().HP_lArm_max = Hero.GetComponent<HeroStats>().HP_lArm_max * 1.2f;
            Hero.GetComponent<HeroStats>().HP_rLeg_max = Hero.GetComponent<HeroStats>().HP_rLeg_max * 1.2f;
            Hero.GetComponent<HeroStats>().HP_lLeg_max = Hero.GetComponent<HeroStats>().HP_lLeg_max * 1.2f;
            
            Hero.GetComponent<HeroStats>().HP_head_rn = Hero.GetComponent<HeroStats>().HP_head_rn * 1.2f;
            Hero.GetComponent<HeroStats>().HP_body_rn = Hero.GetComponent<HeroStats>().HP_body_rn * 1.2f;
            Hero.GetComponent<HeroStats>().HP_rArm_rn = Hero.GetComponent<HeroStats>().HP_rArm_rn * 1.2f;
            Hero.GetComponent<HeroStats>().HP_lArm_rn = Hero.GetComponent<HeroStats>().HP_lArm_rn * 1.2f;
            Hero.GetComponent<HeroStats>().HP_rLeg_rn = Hero.GetComponent<HeroStats>().HP_rLeg_rn * 1.2f;
            Hero.GetComponent<HeroStats>().HP_lLeg_rn = Hero.GetComponent<HeroStats>().HP_lLeg_rn * 1.2f;
        }
    }
    public void x3_head_damage(){
        if(Hero.GetComponent<LvlUp>().lvlPoint > 0 & Hero.GetComponent<HeroEffects>().x3_head_damage == false){
            Hero.GetComponent<LvlUp>().lvlPoint--;
            Hero.GetComponent<HeroEffects>().x3_head_damage = true;
            }
    } 
    public void plus_str_peace_skills(){
        if(Hero.GetComponent<LvlUp>().lvlPoint > 0 & charge_plus_str_peace_skills <= 2 ){
            Hero.GetComponent<LvlUp>().lvlPoint--;
            charge_plus_str_peace_skills++;
            Hero.GetComponent<HeroPeaceSkills>().plus_str_peace_skills = Hero.GetComponent<HeroPeaceSkills>().plus_str_peace_skills + 3;
        }

    }

    public void plus_one_agl(){
        if(Hero.GetComponent<LvlUp>().lvlPoint > 0){
            Hero.GetComponent<LvlUp>().lvlPoint--;
            Hero.GetComponent<HeroStats>().agility++;
        }   
    }

    public void plus_armor(){
        if(Hero.GetComponent<LvlUp>().lvlPoint > 0 & charge_armor <= 2){
            charge_armor++;
            Hero.GetComponent<HeroStats>().plus_armor = Hero.GetComponent<HeroStats>().plus_armor + 2;
            Hero.GetComponent<LvlUp>().lvlPoint--;
            // Hero.GetComponent<HeroStats>().armor_head = Hero.GetComponent<HeroStats>().armor_head + 2;
            // Hero.GetComponent<HeroStats>().armor_body = Hero.GetComponent<HeroStats>().armor_body + 2;
            // Hero.GetComponent<HeroStats>().armor_rArm = Hero.GetComponent<HeroStats>().armor_rArm + 2;
            // Hero.GetComponent<HeroStats>().armor_lArm = Hero.GetComponent<HeroStats>().armor_lArm + 2;
            // Hero.GetComponent<HeroStats>().armor_rLeg = Hero.GetComponent<HeroStats>().armor_rLeg + 2;
            // Hero.GetComponent<HeroStats>().armor_lLeg = Hero.GetComponent<HeroStats>().armor_lLeg + 2;
        }
    }

    public void x1_5_body_damage(){
        if(Hero.GetComponent<LvlUp>().lvlPoint > 0 & Hero.GetComponent<HeroEffects>().x1_5_body_damage == false){
            Hero.GetComponent<LvlUp>().lvlPoint--;
            Hero.GetComponent<HeroEffects>().x1_5_body_damage = true;
            }        
    }
    public void plus_agl_peace_skills(){
        if(Hero.GetComponent<LvlUp>().lvlPoint > 0 & charge_plus_agl_peace_skills <= 2 ){
            Hero.GetComponent<LvlUp>().lvlPoint--;
            charge_plus_agl_peace_skills++;
            Hero.GetComponent<HeroPeaceSkills>().plus_agl_peace_skills = Hero.GetComponent<HeroPeaceSkills>().plus_agl_peace_skills + 3;
        }
    }

    public void plus_one_int(){
        if(Hero.GetComponent<LvlUp>().lvlPoint > 0){
            Hero.GetComponent<LvlUp>().lvlPoint--;
            Hero.GetComponent<HeroStats>().intelligence++;
        }
    }

    public void plus_exp_modificator(){
        if(Hero.GetComponent<LvlUp>().lvlPoint > 0 & charge_exp_modificator <= 3){
            charge_exp_modificator++;
            Hero.GetComponent<LvlUp>().lvlPoint--;
            Hero.GetComponent<HeroStats>().exp_modificator = Hero.GetComponent<HeroStats>().exp_modificator + 0.05f;
        }
    }
    
    public void minus_enemy_armor(){
        if(Hero.GetComponent<LvlUp>().lvlPoint > 0 & charge_minus_enemy_armor <= 2){
            charge_minus_enemy_armor++;
            Hero.GetComponent<LvlUp>().lvlPoint--;
            Hero.GetComponent<HeroStats>().minus_enemy_armor = Hero.GetComponent<HeroStats>().minus_enemy_armor + 2;
            }
    }
    public void plus_int_peace_skills(){
        if(Hero.GetComponent<LvlUp>().lvlPoint > 0 & charge_plus_int_peace_skills <= 2 ){
            Hero.GetComponent<LvlUp>().lvlPoint--;
            charge_plus_int_peace_skills++;
            Hero.GetComponent<HeroPeaceSkills>().plus_int_peace_skills = Hero.GetComponent<HeroPeaceSkills>().plus_int_peace_skills + 3;
        }

    }

    

    public void Update() {

        

        if(Input.GetKeyDown(KeyCode.L)){
            lvlUpMenu.SetActive(!lvlUpMenu.activeInHierarchy);
        }
        if(Hero.GetComponent<LvlUp>().lvlPoint <= 0)
            lvlUpButton.SetActive(false);

        if(Hero.GetComponent<LvlUp>().lvl_hero == 0){                   //обнулення чаржів на прокачку перків після смерті
            charge_max_HP = 0;
            charge_armor = 0;
            charge_exp_modificator = 0;
            charge_minus_enemy_armor = 0;
            charge_plus_str_peace_skills = 0;
            charge_plus_agl_peace_skills = 0;
            charge_plus_int_peace_skills = 0;
        }
            
    }
}
