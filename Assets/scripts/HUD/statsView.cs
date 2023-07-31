using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statsView : MonoBehaviour
{
    public HeroStats stats;
    public HeroPeaceSkills peace_skills;

    public Text STR;
    public Text AGL;
    public Text INT;

    public Text DMG;

    public Text head;
    public Text body;
    public Text rArm;
    public Text lArm;
    public Text rLeg;
    public Text lLeg;

    public Text intimmidate;      //залякування
    public Text athletics;        //атлетика
    public Text endurance;        //витривалість

    public Text acrobatics;       //акробатика
    public Text open_lock;        //відкриття замків
    public Text disable_device;   //знешкодження пасток
    public Text sleight_of_hand;  //спритність рук

    public Text bluff;            //обман
    public Text concentation;     //концентрація
    public Text belief;           //переконання
    public Text knowledge;        //знання
    public Text history;          //історія
    public Text medicine;         //медицина
    public Text alchemy;          //алхімія
    public Text arcana;           //магія
    public Text nature;           //природа
    public Text religion;         //релігія
    public Text survival;         //виживання

    void Update()
    {
        STR.text = "STR:"+stats.strength;
        AGL.text = "AGL:"+stats.agility;
        INT.text = "INT:"+stats.intelligence;

        DMG.text = "DMG:"+stats.DMG;

        head.text = "Head:"+stats.armor_head;
        body.text = "Body:"+stats.armor_body;
        rArm.text = "rArm:"+stats.armor_rArm;
        lArm.text = "lArm:"+stats.armor_lArm;
        rLeg.text = "rLeg:"+stats.armor_rLeg;
        lLeg.text = "lLeg:"+stats.armor_lLeg;

        intimmidate.text = "intimmidate:"+peace_skills.intimmidate;      //залякування
        athletics.text = "athletics:"+peace_skills.athletics;        //атлетика
        endurance.text = "endurance:"+peace_skills.endurance;        //витривалість        

        acrobatics.text = "acrobatics:"+peace_skills.acrobatics;       //акробатика
        open_lock.text = "open lock:"+peace_skills.open_lock;        //відкриття замків
        disable_device.text = "disable device:"+peace_skills.disable_device;   //знешкодження пасток
        sleight_of_hand.text = "sleight of hand:"+peace_skills.sleight_of_hand;  //спритність рук

        bluff.text = "bluff:"+peace_skills.bluff;            //обман
        concentation.text = "concentation:"+peace_skills.concentation;     //концентрація
        belief.text = "belief:"+peace_skills.belief;           //переконання
        knowledge.text = "knowledge:"+peace_skills.knowledge;        //знання
        history.text = "history:"+peace_skills.history;          //історія
        medicine.text = "medicine:"+peace_skills.medicine;         //медицина
        alchemy.text = "alchemy:"+peace_skills.alchemy;          //алхімія
        arcana.text = "arcana:"+peace_skills.arcana;           //магія
        nature.text = "nature:"+peace_skills.nature;           //природа
        religion.text = "religion:"+peace_skills.religion;         //релігія
        survival.text = "survival:"+peace_skills.survival;         //виживання        intimmidate.text = 
    }


}
