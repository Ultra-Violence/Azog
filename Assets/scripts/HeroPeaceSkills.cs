using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroPeaceSkills : MonoBehaviour
{
    public int intimmidate = 0;      //залякування
    public int athletics = 0;        //атлетика
    public int endurance = 0;        //витривалість

    public int acrobatics = 0;       //акробатика
    public int open_lock = 0;        //відкриття замків
    public int disable_device = 0;   //знешкодження пасток
    public int sleight_of_hand = 0;  //спритність рук

    public int bluff = 0;            //обман
    public int concentation = 0;     //концентрація
    public int belief = 0;           //переконання
    public int knowledge = 0;        //знання
    public int history = 0;          //історія
    public int medicine = 0;         //медицина
    public int alchemy = 0;          //алхімія
    public int arcana = 0;           //магія
    public int nature = 0;           //природа
    public int religion = 0;         //релігія
    public int survival = 0;         //виживання

    // static public int static_intimmidate = 1;      //залякування
    // static public int static_athletics = 1;        //атлетика
    // static public int static_endurance = 1;        //витривалість

    // static public int static_acrobatics = 1;       //акробатика
    // static public int static_open_lock = 1;        //відкриття замків
    // static public int static_disable_device = 1;   //знешкодження пасток
    // static public int static_sleight_of_hand = 1;  //спритність рук

    // static public int static_bluff = 1;            //обман
    // static public int static_concentation = 1;     //концентрація
    // static public int static_belief = 1;           //переконання
    // static public int static_knowledge = 1;        //знання
    // static public int static_history = 1;          //історія
    // static public int static_medicine = 1;         //медицина
    // static public int static_alchemy = 1;          //алхімія
    // static public int static_arcana = 1;           //магія
    // static public int static_nature = 1;           //природа
    // static public int static_religion = 1;         //релігія
    // static public int static_survival = 1;         //виживання

    public int plus_str_peace_skills = 0;
    static public int static_plus_str_peace_skills = 0;
    public int plus_agl_peace_skills = 0;
    static public int static_plus_agl_peace_skills = 0;
    public int plus_int_peace_skills = 0;
    static public int static_plus_int_peace_skills = 0;

    private void Awake() {

        // HeroStats = HeroStats.GetComponent<HeroStats>();

        plus_str_peace_skills = static_plus_str_peace_skills;      //сейв
        plus_agl_peace_skills = static_plus_agl_peace_skills;
        plus_int_peace_skills = static_plus_int_peace_skills;

        // intimmidate = static_intimmidate;
        // athletics = static_athletics;
        // endurance = static_endurance;

        // acrobatics = static_acrobatics;
        // open_lock = static_open_lock;
        // disable_device = static_disable_device;
        // sleight_of_hand = static_sleight_of_hand;

        // bluff = static_bluff;
        // concentation = static_concentation;
        // belief = static_belief;
        // knowledge = static_knowledge;
        // history = static_history;
        // medicine = static_medicine;
        // alchemy = static_alchemy;
        // arcana = static_arcana;
        // nature = static_nature;
        // religion = static_religion;
        // survival = static_survival;
        
    }
    public void Update() {

        static_plus_str_peace_skills = plus_str_peace_skills;
        static_plus_agl_peace_skills = plus_agl_peace_skills;
        static_plus_int_peace_skills = plus_int_peace_skills;

        intimmidate = gameObject.GetComponent<HeroStats>().strength + plus_str_peace_skills;
        athletics = gameObject.GetComponent<HeroStats>().strength + plus_str_peace_skills;
        endurance = gameObject.GetComponent<HeroStats>().strength + plus_str_peace_skills;

        acrobatics = gameObject.GetComponent<HeroStats>().agility + plus_agl_peace_skills;
        open_lock = gameObject.GetComponent<HeroStats>().agility + plus_agl_peace_skills;
        disable_device = gameObject.GetComponent<HeroStats>().agility + plus_agl_peace_skills;
        sleight_of_hand = gameObject.GetComponent<HeroStats>().agility + plus_agl_peace_skills;

        bluff = gameObject.GetComponent<HeroStats>().intelligence + plus_int_peace_skills;
        concentation = gameObject.GetComponent<HeroStats>().intelligence + plus_int_peace_skills;
        belief = gameObject.GetComponent<HeroStats>().intelligence + plus_int_peace_skills;
        knowledge = gameObject.GetComponent<HeroStats>().intelligence + plus_int_peace_skills;
        history = gameObject.GetComponent<HeroStats>().intelligence + plus_int_peace_skills;
        medicine = gameObject.GetComponent<HeroStats>().intelligence + plus_int_peace_skills;
        alchemy = gameObject.GetComponent<HeroStats>().intelligence + plus_int_peace_skills;
        arcana = gameObject.GetComponent<HeroStats>().intelligence + plus_int_peace_skills;
        nature = gameObject.GetComponent<HeroStats>().intelligence + plus_int_peace_skills;
        religion = gameObject.GetComponent<HeroStats>().intelligence + plus_int_peace_skills;
        survival = gameObject.GetComponent<HeroStats>().intelligence + plus_int_peace_skills;

        // static_intimmidate = intimmidate;
        // static_athletics = athletics;
        // static_endurance = endurance;

        // static_acrobatics = acrobatics;
        // static_open_lock = open_lock;
        // static_disable_device = disable_device;
        // static_sleight_of_hand = sleight_of_hand;

        // static_bluff = bluff;
        // static_concentation = concentation;
        // static_belief = belief;
        // static_knowledge = knowledge;
        // static_history = history;
        // static_medicine = medicine;
        // static_alchemy = alchemy;
        // static_arcana = arcana;
        // static_nature = nature;
        // static_religion = religion;
        // static_survival = survival;

    }
}
