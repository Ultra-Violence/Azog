using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoblinFight : MonoBehaviour
{
    public float main_stat = 1f;

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

    public Slider Goblin_HP;
    public Slider Goblin_Head;
    public Slider Goblin_Body;
    public Slider Goblin_rArm;
    public Slider Goblin_lArm;
    public Slider Goblin_rLeg;
    public Slider Goblin_lLeg;

    public GameObject Hero;
    public GameObject Goblin;
    public GameObject WinMenu;
    public GameObject EndMenu;
    public GameObject esc_HUD;

    private HeroStats heroHP;
    private GoblinStats goblinHP;
    public Control text_hit;

    public Animator Hero_Animator;
    public Animator Goblin_Animator;

    public Color HeroTextColor;
    public Color GoblinTextColor;

    private int i  = 0;


    List<string> chance_to_hit = new List<string>() { "Hero hit in the head!", "Hero hit in the body", "Hero hit in the body", "Hero hit in the body", "Hero hit in the body", "Hero hit in the right arm", "Hero hit in the right arm", "Hero hit in the left arm", "Hero hit in the left arm", "Hero hit in the right leg", "Hero hit in the right leg", "Hero hit in the left leg", "Hero hit in the left leg" };
    List<string> chance_to_hit_enemy = new List<string>() { "Enemy hit in the head!", "Enemy hit in the body", "Enemy hit in the body", "Enemy hit in the body", "Enemy hit in the body", "Enemy hit in the right arm", "Enemy Hero hit in the right arm", "Enemy Hero hit in the left arm", "Enemy Hero hit in the left arm", "Enemy hit in the right leg", "Enemy hit in the right leg", "Enemy hit in the left leg", "Enemy hit in the left leg" };

    void Awake() {
        heroHP = Hero.GetComponent<HeroStats>();
        goblinHP = Goblin.GetComponent<GoblinStats>();


    }

    private void Start() {

        StartCoroutine(fight());
        Goblin_Animator.Play("goblin_attack", 0, 1f);

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

        if(heroHP.HP_rn > 0 | goblinHP.HP_rn > 0){

            

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
        else if(goblinHP.HP_rn <= 0 | goblinHP.HP_head_rn <= 0 | goblinHP.HP_body_rn <= 0){

            for(; i == 0;){                                                     //досвід лише один раз
            Hero.GetComponent<LvlUp>().plus_exp(100);           
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


        Goblin_HP.maxValue = goblinHP.HP_max;
        Goblin_HP.value = goblinHP.HP_rn;

        Goblin_Head.maxValue = goblinHP.HP_head_max;
        Goblin_Head.value = goblinHP.HP_head_rn;

        Goblin_Body.maxValue = goblinHP.HP_body_max;
        Goblin_Body.value = goblinHP.HP_body_rn;

        Goblin_rArm.maxValue = goblinHP.HP_rArm_max;
        Goblin_rArm.value = goblinHP.HP_rArm_rn;

        Goblin_lArm.maxValue = goblinHP.HP_lArm_max;
        Goblin_lArm.value = goblinHP.HP_lArm_rn;

        Goblin_rLeg.maxValue = goblinHP.HP_rLeg_max;
        Goblin_rLeg.value = goblinHP.HP_rLeg_rn;

        Goblin_lLeg.maxValue = goblinHP.HP_lLeg_max;
        Goblin_lLeg.value = goblinHP.HP_lLeg_rn;
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

        if(random_hit == "Hero hit in the head!" & goblinHP.armor_head < str_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.str_weapon_type == true)                         //нанесення урону в залежності від того куди влучив удар
            goblinHP.hit_head(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the head!" & goblinHP.armor_head < agl_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.agl_weapon_type == true)                                    
            goblinHP.hit_head(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the head!" & goblinHP.armor_head < int_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.int_weapon_type == true)                                    
            goblinHP.hit_head(Hero.GetComponent<HeroStats>().DMG);

        else if(random_hit == "Hero hit in the body" & goblinHP.armor_body < str_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.str_weapon_type == true)
            goblinHP.hit_body(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the body" & goblinHP.armor_body < agl_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.agl_weapon_type == true)
            goblinHP.hit_body(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the body" & goblinHP.armor_body < int_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.int_weapon_type == true)
            goblinHP.hit_body(Hero.GetComponent<HeroStats>().DMG);

        else if(random_hit == "Hero hit in the right arm" & goblinHP.armor_rArm < str_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.str_weapon_type == true)
            goblinHP.hit_rArm(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the right arm" & goblinHP.armor_rArm < agl_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.agl_weapon_type == true)
            goblinHP.hit_rArm(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the right arm" & goblinHP.armor_rArm < int_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.int_weapon_type == true)
            goblinHP.hit_rArm(Hero.GetComponent<HeroStats>().DMG);

        else if(random_hit == "Hero hit in the left arm" & goblinHP.armor_lArm < str_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.str_weapon_type == true)
            goblinHP.hit_lArm(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the left arm" & goblinHP.armor_lArm < agl_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.agl_weapon_type == true)
            goblinHP.hit_lArm(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the left arm" & goblinHP.armor_lArm < int_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.int_weapon_type == true)
            goblinHP.hit_lArm(Hero.GetComponent<HeroStats>().DMG);

        else if(random_hit == "Hero hit in the right leg" & goblinHP.armor_rLeg < str_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.str_weapon_type == true)
            goblinHP.hit_rLeg(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the right leg" & goblinHP.armor_rLeg < agl_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.agl_weapon_type == true)
            goblinHP.hit_rLeg(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the right leg" & goblinHP.armor_rLeg < int_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.int_weapon_type == true)
            goblinHP.hit_rLeg(Hero.GetComponent<HeroStats>().DMG);

        else if(random_hit == "Hero hit in the left leg" & goblinHP.armor_lLeg < str_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.str_weapon_type == true)
            goblinHP.hit_lLeg(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the left leg" & goblinHP.armor_lLeg < agl_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.agl_weapon_type == true)
            goblinHP.hit_lLeg(Hero.GetComponent<HeroStats>().DMG);
        else if(random_hit == "Hero hit in the left leg" & goblinHP.armor_lLeg < int_d20 + Hero.GetComponent<HeroStats>().minus_enemy_armor & heroHP.int_weapon_type == true)
            goblinHP.hit_lLeg(Hero.GetComponent<HeroStats>().DMG);
        
    }

    public void random_hit_to_hero(){

        System.Random random_d20 = new System.Random();
        int random_d20_hit = random_d20.Next(21);

        System.Random random = new System.Random();  //новий рандом
        int random_Index = random.Next(chance_to_hit_enemy.Count);  //некст дозволяє брати число від 0 до заданого
        string random_hit = chance_to_hit_enemy[random_Index];  //обираємо випадковий індекс

        text_hit.LogText(random_hit, GoblinTextColor );

        if(random_hit == "Enemy hit in the head!" & heroHP.armor_head < random_d20_hit + main_stat)                                     //нанесення урону в залежності від того куди влучив удар
            heroHP.hit_head(Goblin.GetComponent<GoblinStats>().DMG);
        else if(random_hit == "Enemy hit in the body" & heroHP.armor_body < random_d20_hit + main_stat)
            heroHP.hit_body(Goblin.GetComponent<GoblinStats>().DMG);
        else if(random_hit == "Enemy hit in the right arm" & heroHP.armor_rArm < random_d20_hit + main_stat)
            heroHP.hit_rArm(Goblin.GetComponent<GoblinStats>().DMG);
        else if(random_hit == "Enemy Hero hit in the left arm" & heroHP.armor_lArm < random_d20_hit + main_stat)
            heroHP.hit_lArm(Goblin.GetComponent<GoblinStats>().DMG);
        else if(random_hit == "Enemy hit in the right leg" & heroHP.armor_rLeg < random_d20_hit + main_stat)
            heroHP.hit_rLeg(Goblin.GetComponent<GoblinStats>().DMG);
        else if(random_hit == "Enemy hit in the left leg" & heroHP.armor_lLeg < random_d20_hit + main_stat)
            heroHP.hit_lLeg(Goblin.GetComponent<GoblinStats>().DMG);
        


    }  
}
