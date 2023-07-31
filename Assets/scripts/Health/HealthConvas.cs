using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthConvas : MonoBehaviour
{
    public HeroStats hs;

    public GameObject Health_Convas;
    public Slider HP_bar;
    public Slider HP_Headbar;   
    public Slider HP_Bodybar;
    public Slider HP_rArmbar;
    public Slider HP_lArmbar;
    public Slider HP_rLegbar;
    public Slider HP_lLegbar;

    private void Update() {

            if(Input.GetKeyDown(KeyCode.H)){
            Health_Convas.SetActive(!Health_Convas.activeInHierarchy);  //перемикач відображення конвасу з хп
        }

        HP_bar.maxValue = hs.HP_max;
        HP_bar.value = hs.HP_rn;

        HP_Headbar.maxValue = hs.HP_head_max;
        HP_Headbar.value = hs.HP_head_rn;

        HP_Bodybar.maxValue = hs.HP_body_max;
        HP_Bodybar.value = hs.HP_body_rn;

        HP_rArmbar.maxValue = hs.HP_rArm_max;
        HP_rArmbar.value = hs.HP_rArm_rn;

        HP_lArmbar.maxValue = hs.HP_lArm_max;
        HP_lArmbar.value = hs.HP_lArm_rn;

        HP_rLegbar.maxValue = hs.HP_rLeg_max;
        HP_rLegbar.value = hs.HP_rLeg_rn;

        HP_lLegbar.maxValue = hs.HP_lLeg_max;
        HP_lLegbar.value = hs.HP_lLeg_rn;
    }

    public void esc_button(){
        Health_Convas.SetActive(false);
    }
}
