using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkGoblinStats : MonoBehaviour
{
    public GameObject Hero;

    public float HP_max;
    public float HP_rn;

    public float HP_head_max = 20f;
    public float HP_head_rn = 20f;
    public float armor_head = 3f;

    public float HP_body_max = 60f;
    public float HP_body_rn = 60f;
    public float armor_body = 4f;

    public float HP_lArm_max = 30f;
    public float HP_lArm_rn = 30f;
    public float armor_rArm = 3f;

    public float HP_rArm_max = 30f;
    public float HP_rArm_rn = 30f;
    public float armor_lArm = 3f;

    public float HP_lLeg_max = 35f;
    public float HP_lLeg_rn = 35f;
    public float armor_rLeg = 3f;

    public float HP_rLeg_max = 35f;
    public float HP_rLeg_rn = 35f;
    public float armor_lLeg = 3f;

    public float DMG = 8f;

    private void Awake() {

        HP_head_rn = HP_head_max;
    
    }

    void Update() {
            
        if(HP_rn > HP_max)       //щоб поточний рівень здоров'я не перевищував максимальний
            HP_rn = HP_max;
        
        if(HP_body_rn <= 0 | HP_head_rn <= 0)
            HP_rn = 0;

        if(HP_head_rn > HP_head_max)
            HP_head_rn = HP_head_max;
        
        if(HP_body_rn > HP_body_max)
            HP_body_rn = HP_body_max;
        
        if(HP_rArm_rn > HP_rArm_max)
            HP_rArm_rn = HP_rArm_max;
        
        if(HP_lArm_rn > HP_lArm_max)
            HP_lArm_rn = HP_lArm_max;
        
        if(HP_rLeg_rn > HP_rLeg_max)
            HP_rLeg_rn = HP_rLeg_max;

        if(HP_lLeg_rn > HP_lLeg_max)
            HP_lLeg_rn = HP_lLeg_max;


        HP_max = HP_head_max + HP_body_max + HP_lArm_max + HP_rArm_max + HP_lLeg_max + HP_rLeg_max ;

        HP_rn = HP_head_rn + HP_body_rn + HP_lArm_rn + HP_rArm_rn + HP_lLeg_rn + HP_rLeg_rn;

    }

    public void hit_head(float damage){
        if(Hero.GetComponent<HeroEffects>().x3_head_damage == true)
            HP_head_rn -= damage*3;
        else 
            HP_head_rn -= damage*2;
    }

    public void hit_body(float damage){
        if(Hero.GetComponent<HeroEffects>().x1_5_body_damage == true )
            HP_body_rn -= damage*1.5f;
        else
            HP_body_rn -= damage;
    }

    public void hit_rArm(float damage){
        HP_rArm_rn -= damage;
    }

    public void hit_lArm(float damage){
        HP_lArm_rn -= damage;
    }

    public void hit_rLeg(float damage){
        HP_rLeg_rn -= damage;
    }

    public void hit_lLeg(float damage){
        HP_lLeg_rn -= damage;
    }


    
}

