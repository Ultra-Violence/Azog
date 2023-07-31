using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DarkGoblinFight : MonoBehaviour
{
    public float main_stat = 3f;

    public Sprite fists_idle;
    public Sprite Stick_of_yura_idle;
    public Sprite Spear_of_yura_idle;
    public Sprite Staff_of_yura_idle;

    public Slider Hero_HP;
    public Slider Hero_Head;
    public Slider Hero_Body;
    public Slider Hero_rArm;
    public Slider Hero_lArm;
    public Slider Hero_rLeg;
    public Slider Hero_lLeg;

    public Slider DarkGoblin_HP;
    public Slider DarkGoblin_Head;
    public Slider DarkGoblin_Body;
    public Slider DarkGoblin_rArm;
    public Slider DarkGoblin_lArm;
    public Slider DarkGoblin_rLeg;
    public Slider DarkGoblin_lLeg;

    public GameObject Hero;
    public GameObject DarkGoblin;
    public GameObject WinMenu;
    public GameObject EndMenu;
    public GameObject esc_HUD;

    private HeroStats heroHP;
    private DarkGoblinStats DarkgoblinHP;
    public DarkGoblinTextLog text_hit;

    public Animator Hero_Animator;
    public Animator DarkGoblin_Animator;

    public Color HeroTextColor;
    public Color DarkGoblinTextColor;

    private int i  = 0;


    List<string> chance_to_hit = new List<string>() { "Hero hit in the head!", "Hero hit in the body", "Hero hit in the body", "Hero hit in the body", "Hero hit in the body", "Hero hit in the right arm", "Hero hit in the right arm", "Hero hit in the left arm", "Hero hit in the left arm", "Hero hit in the right leg", "Hero hit in the right leg", "Hero hit in the left leg", "Hero hit in the left leg" };
    List<string> chance_to_hit_enemy = new List<string>() { "Enemy hit in the head!", "Enemy hit in the body", "Enemy hit in the body", "Enemy hit in the body", "Enemy hit in the body", "Enemy hit in the right arm", "Enemy Hero hit in the right arm", "Enemy Hero hit in the left arm", "Enemy Hero hit in the left arm", "Enemy hit in the right leg", "Enemy hit in the right leg", "Enemy hit in the left leg", "Enemy hit in the left leg" };

    void Awake() {
        heroHP = Hero.GetComponent<HeroStats>();
        DarkgoblinHP = DarkGoblin.GetComponent<DarkGoblinStats>();


    }

    private void Start() {

        StartCoroutine(fight());
        DarkGoblin_Animator.Play("darkgoblin_attack", 0, 1f);

    }

    public void Win(){
        SceneManager.LoadScene("SampleScene");
    }

    public void Lose(){
        SceneManager.LoadScene("Menu");
    }

    public void Quit_button(){
        Application.Quit();
    }

    IEnumerator fight(){
        //yield return new WaitForSeconds(0.5f);

        if(heroHP.HP_rn > 0 | DarkgoblinHP.HP_rn > 0){

            

            if(Hero.GetComponent<Items>().fists == true)
                Hero_Animator.Play("hero_fighter", 0, 1f); 
            else if(Hero.GetComponent<Items>().Stick_of_yura == true)
                Hero_Animator.Play("hero_stick_of_yura", 0, 1f); 
            else if(Hero.GetComponent<Items>().Spear_of_yura == true)
                Hero_Animator.Play("hero_spear_of_yura", 0, 1f);
            else if(Hero.GetComponent<Items>().Staff_of_yura == true)
                Hero_Animator.Play("hero_wand_of_yura", 0, 1f);
                
            

            random_hit_to_enemy();
            yield return new WaitForSeconds(1f);
            random_hit_to_hero();

            
        }
        StartCoroutine(fight());
    }

    public void Update() {

        if(heroHP.HP_body_rn <= 0 | heroHP.HP_head_rn <= 0 | heroHP.HP_rn <= 0){
            EndMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else if(DarkgoblinHP.HP_rn <= 0 | DarkgoblinHP.HP_head_rn <= 0 | DarkgoblinHP.HP_body_rn <= 0){

            for(; i == 0;){                                                     //досвід лише один раз
            Hero.GetComponent<LvlUp>().plus_exp(300);           
            i++;
            }
            Time.timeScale = 0;
            WinMenu.SetActive(true);
        }

        if(WinMenu.activeInHierarchy == true){
            Hero.GetComponent<AudioSource>().mute = true;
        }
        if(EndMenu.activeInHierarchy == true){
            Hero.GetComponent<AudioSource>().mute = true;
        }

        if(Input.GetKeyDown(KeyCode.Escape)){
            esc_HUD.SetActive(!esc_HUD.activeInHierarchy);
        }

        Hero_HP.maxValue = heroHP.HP_max;                   //хп конвас для героя
        Hero_HP.value = heroHP.HP_rn;

        Hero_Head.maxValue = heroHP.HP_head_max;
        Hero_Head.value = heroHP.HP_head_rn;

        Hero_Body.maxValue = heroHP.HP_body_max;
        Hero_Body.value = heroHP.HP_body_rn;

        Hero_rArm.maxValue = heroHP.HP_rArm_max;
        Hero_rArm.value = heroHP.HP_rArm_rn;

        Hero_lArm.maxValue = heroHP.HP_lArm_max;
        Hero_lArm.value = heroHP.HP_lArm_rn;

        Hero_rLeg.maxValue = heroHP.HP_rLeg_max;
        Hero_rLeg.value = heroHP.HP_rLeg_rn;

        Hero_lLeg.maxValue = heroHP.HP_lLeg_max;
        Hero_lLeg.value = heroHP.HP_lLeg_rn;


        DarkGoblin_HP.maxValue = DarkgoblinHP.HP_max;
        DarkGoblin_HP.value = DarkgoblinHP.HP_rn;

        DarkGoblin_Head.maxValue = DarkgoblinHP.HP_head_max;
        DarkGoblin_Head.value = DarkgoblinHP.HP_head_rn;

        DarkGoblin_Body.maxValue = DarkgoblinHP.HP_body_max;
        DarkGoblin_Body.value = DarkgoblinHP.HP_body_rn;

        DarkGoblin_rArm.maxValue = DarkgoblinHP.HP_rArm_max;
        DarkGoblin_rArm.value = DarkgoblinHP.HP_rArm_rn;

        DarkGoblin_lArm.maxValue = DarkgoblinHP.HP_lArm_max;
        DarkGoblin_lArm.value = DarkgoblinHP.HP_lArm_rn;

        DarkGoblin_rLeg.maxValue = DarkgoblinHP.HP_rLeg_max;
        DarkGoblin_rLeg.value = DarkgoblinHP.HP_rLeg_rn;

        DarkGoblin_lLeg.maxValue = DarkgoblinHP.HP_lLeg_max;
        DarkGoblin_lLeg.value = DarkgoblinHP.HP_lLeg_rn;
    } 

    public void random_hit_to_enemy(){

        System.Random random_d20 = new System.Random();
        int random_d20_hit = random_d20.Next(21);
        int str_d20 = random_d20_hit + (int)heroHP.strength;
        int agl_d20 = random_d20_hit + (int)heroHP.agility;
        int int_d20 = random_d20_hit + (int)heroHP.intelligence;

        System.Random random = new System.Random();  //новий рандом
        int random_Index = random.Next(chance_to_hit.Count);  //некст дозволяє брати число від 0 до заданого
        string random_hit = chance_to_hit[random_Index];  //обираємо випадковий індекс


        text_hit.LogText(random_hit, HeroTextColor );

        if(random_hit == "Hero hit in the head!" & DarkgoblinHP.armor_head < str_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.str_weapon_type == true)                         //нанесення урону в залежності від того куди влучив удар
            DarkgoblinHP.hit_head(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the head!" & DarkgoblinHP.armor_head < agl_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.agl_weapon_type == true)                                    
            DarkgoblinHP.hit_head(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the head!" & DarkgoblinHP.armor_head < int_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.int_weapon_type == true)                                    
            DarkgoblinHP.hit_head(Hero.GetComponent<HeroStats>().DMG);

        else if(random_hit == "Hero hit in the body" & DarkgoblinHP.armor_body < str_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.str_weapon_type == true)
            DarkgoblinHP.hit_body(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the body" & DarkgoblinHP.armor_body < agl_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.agl_weapon_type == true)
            DarkgoblinHP.hit_body(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the body" & DarkgoblinHP.armor_body < int_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.int_weapon_type == true)
            DarkgoblinHP.hit_body(Hero.GetComponent<HeroStats>().DMG);

        else if(random_hit == "Hero hit in the right arm" & DarkgoblinHP.armor_rArm < str_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.str_weapon_type == true)
            DarkgoblinHP.hit_rArm(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the right arm" & DarkgoblinHP.armor_rArm < agl_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.agl_weapon_type == true)
            DarkgoblinHP.hit_rArm(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the right arm" & DarkgoblinHP.armor_rArm < int_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.int_weapon_type == true)
            DarkgoblinHP.hit_rArm(Hero.GetComponent<HeroStats>().DMG);

        else if(random_hit == "Hero hit in the left arm" & DarkgoblinHP.armor_lArm < str_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.str_weapon_type == true)
            DarkgoblinHP.hit_lArm(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the left arm" & DarkgoblinHP.armor_lArm < agl_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.agl_weapon_type == true)
            DarkgoblinHP.hit_lArm(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the left arm" & DarkgoblinHP.armor_lArm < int_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.int_weapon_type == true)
            DarkgoblinHP.hit_lArm(Hero.GetComponent<HeroStats>().DMG);

        else if(random_hit == "Hero hit in the right leg" & DarkgoblinHP.armor_rLeg < str_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.str_weapon_type == true)
            DarkgoblinHP.hit_rLeg(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the right leg" & DarkgoblinHP.armor_rLeg < agl_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.agl_weapon_type == true)
            DarkgoblinHP.hit_rLeg(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the right leg" & DarkgoblinHP.armor_rLeg < int_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.int_weapon_type == true)
            DarkgoblinHP.hit_rLeg(Hero.GetComponent<HeroStats>().DMG);

        else if(random_hit == "Hero hit in the left leg" & DarkgoblinHP.armor_lLeg < str_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.str_weapon_type == true)
            DarkgoblinHP.hit_lLeg(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the left leg" & DarkgoblinHP.armor_lLeg < agl_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.agl_weapon_type == true)
            DarkgoblinHP.hit_lLeg(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the left leg" & DarkgoblinHP.armor_lLeg < int_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.int_weapon_type == true)
            DarkgoblinHP.hit_lLeg(Hero.GetComponent<HeroStats>().DMG);
        
    }

    public void random_hit_to_hero(){

        System.Random random_d20 = new System.Random();
        int random_d20_hit = random_d20.Next(21);

        System.Random random = new System.Random();  //новий рандом
        int random_Index = random.Next(chance_to_hit_enemy.Count);  //некст дозволяє брати число від 0 до заданого
        string random_hit = chance_to_hit_enemy[random_Index];  //обираємо випадковий індекс

        text_hit.LogText(random_hit, DarkGoblinTextColor );

        if(random_hit == "Enemy hit in the head!" & heroHP.armor_head < random_d20_hit + main_stat)                                     //нанесення урону в залежності від того куди влучив удар
            heroHP.hit_head(DarkGoblin.GetComponent<DarkGoblinStats>().DMG);
        else if(random_hit == "Enemy hit in the body" & heroHP.armor_body < random_d20_hit + main_stat)
            heroHP.hit_body(DarkGoblin.GetComponent<DarkGoblinStats>().DMG);
        else if(random_hit == "Enemy hit in the right arm" & heroHP.armor_rArm < random_d20_hit + main_stat)
            heroHP.hit_rArm(DarkGoblin.GetComponent<DarkGoblinStats>().DMG);
        else if(random_hit == "Enemy Hero hit in the left arm" & heroHP.armor_lArm < random_d20_hit + main_stat)
            heroHP.hit_lArm(DarkGoblin.GetComponent<DarkGoblinStats>().DMG);
        else if(random_hit == "Enemy hit in the right leg" & heroHP.armor_rLeg < random_d20_hit + main_stat)
            heroHP.hit_rLeg(DarkGoblin.GetComponent<DarkGoblinStats>().DMG);
        else if(random_hit == "Enemy hit in the left leg" & heroHP.armor_lLeg < random_d20_hit + main_stat)
            heroHP.hit_lLeg(DarkGoblin.GetComponent<DarkGoblinStats>().DMG);
        


    }  
}
