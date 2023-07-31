using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDexp : MonoBehaviour
{
    public LvlUp LvlUp;
    public Slider HP_bar;

    void Update()
    {   
        if(LvlUp.lvl_hero == 0){
            HP_bar.maxValue = 100;
            HP_bar.value = LvlUp.exp;
        }
        else if(LvlUp.lvl_hero == 1){
            HP_bar.maxValue = 300;
            HP_bar.value = LvlUp.exp;
        }
        else if(LvlUp.lvl_hero == 2){
            HP_bar.maxValue = 900;
            HP_bar.value = LvlUp.exp;
        }
        else if(LvlUp.lvl_hero == 3){
            HP_bar.maxValue = 2700;
            HP_bar.value = LvlUp.exp;
        }
        else if(LvlUp.lvl_hero == 4){
            HP_bar.maxValue = 8100;
            HP_bar.value = LvlUp.exp;
        }
        else if(LvlUp.lvl_hero == 5){
            HP_bar.maxValue = 24300;
            HP_bar.value = LvlUp.exp;
        }
        else if(LvlUp.lvl_hero == 6){
            HP_bar.maxValue = 72900;
            HP_bar.value = LvlUp.exp;
        }
        else if(LvlUp.lvl_hero == 7){
            HP_bar.maxValue = 218700;
            HP_bar.value = LvlUp.exp;
        }
        else if(LvlUp.lvl_hero == 8){
            HP_bar.maxValue = 656100;
            HP_bar.value = LvlUp.exp;
        }
        else if(LvlUp.lvl_hero == 9){
            HP_bar.maxValue = 1968300;
            HP_bar.value = LvlUp.exp;
        }


    }
}
