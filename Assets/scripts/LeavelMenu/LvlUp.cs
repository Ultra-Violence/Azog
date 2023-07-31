using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LvlUp : MonoBehaviour
{
    public GameObject lvlupButton;
    public GameObject lvlUpMenu;
    public Text pointScore;

    public float exp = 0;
    static public float static_exp = 0;
    public int lvl_hero = 0;
    static public int static_lvl_hero = 0;
    public int lvlPoint = 0;
    static public int static_lvlPoint = 0;

    public bool lvlup;
    static public bool static_lvlup;

    private void Awake() {
        exp = static_exp;
        lvl_hero = static_lvl_hero;
        lvlPoint = static_lvlPoint;
        lvlup = static_lvlup;
    }

    private void OnEnable() {
        if(lvlup == true & SceneManager.GetActiveScene().name == "SampleScene")   //відображення стрілочки лише в потрібній сцені
            lvlupButton.SetActive(true);
    }

    private void Start() {                  // для того ж
        lvlup = false;
    }

 
    void Update(){
        if(SceneManager.GetActiveScene().name == "SampleScene")
            pointScore.text = lvlPoint.ToString();

        static_exp = exp;
        static_lvl_hero = lvl_hero;
        static_lvlPoint = lvlPoint;
        static_lvlup = lvlup;
        

        for(; exp >= 100 & lvl_hero == 0;){                //начислення поінтів за лвл і виклик стілочки
            lvl_hero++;
            lvlup = true;
            lvlPoint = lvlPoint + 2;
            if(SceneManager.GetActiveScene().name == "SampleScene")
                lvlupButton.SetActive(true);
            }
        for(; exp >= 300 & lvl_hero == 1;){
            lvl_hero++;
            lvlup = true;
            lvlPoint = lvlPoint + 2;
            if(SceneManager.GetActiveScene().name == "SampleScene")
                lvlupButton.SetActive(true);
            }
        for(; exp >= 900 & lvl_hero == 2;){
            lvl_hero++;
            lvlup = true;
            lvlPoint = lvlPoint + 2;
            if(SceneManager.GetActiveScene().name == "SampleScene")
                lvlupButton.SetActive(true);
            }
        for(; exp >= 2700 & lvl_hero == 3;){
            lvl_hero++;
            lvlup = true;
            lvlPoint = lvlPoint + 2;
            if(SceneManager.GetActiveScene().name == "SampleScene")
                lvlupButton.SetActive(true);
            }
        for(; exp >= 8100 & lvl_hero == 4;){
            lvl_hero++;
            lvlup = true;
            lvlPoint = lvlPoint + 2;
            if(SceneManager.GetActiveScene().name == "SampleScene")
                lvlupButton.SetActive(true);
            }
        for(; exp >= 24300 & lvl_hero == 5;){
            lvl_hero++;
            lvlup = true;
            lvlPoint = lvlPoint + 2;
            if(SceneManager.GetActiveScene().name == "SampleScene")
                lvlupButton.SetActive(true);
            }
        for(; exp >= 72900 & lvl_hero == 6;){
            lvl_hero++;
            lvlup = true;
            lvlPoint = lvlPoint + 2;
            if(SceneManager.GetActiveScene().name == "SampleScene")
                lvlupButton.SetActive(true);
            }
        for(; exp >= 218700 & lvl_hero == 7;){
            lvl_hero++;
            lvlup = true;
            lvlPoint = lvlPoint + 2;
            if(SceneManager.GetActiveScene().name == "SampleScene")
                lvlupButton.SetActive(true);
            }
        for(; exp >= 656100 & lvl_hero == 8;){
            lvl_hero++;
            lvlup = true;
            lvlPoint = lvlPoint + 2;
            if(SceneManager.GetActiveScene().name == "SampleScene")
                lvlupButton.SetActive(true);
            }
        for(; exp >= 1968300  & lvl_hero == 9;){
            lvl_hero++;
            lvlup = true;
            lvlPoint = lvlPoint + 2;
            if(SceneManager.GetActiveScene().name == "SampleScene")
                lvlupButton.SetActive(true);
            }   
    }

    public void plus_exp(float kill_exp){                                                 //exp за кіл
        exp += (kill_exp * gameObject.GetComponent<HeroStats>().exp_modificator);
        static_exp = exp;
    }


}
