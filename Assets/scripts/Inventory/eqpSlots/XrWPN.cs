using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XrWPN : MonoBehaviour
{
    public GameObject slot;             //відображення хрестика
    public GameObject Hero;
    public GameObject MainCamera;

    void Update()
    {
        if(slot.GetComponent<rWPNSlot>().empty == false){
            gameObject.GetComponent<Image>().enabled = true;

        }
        else if(slot.GetComponent<rWPNSlot>().empty == true){
            gameObject.GetComponent<Image>().enabled = false;
        }
    }

    public void clear(){
        slot.GetComponent<rWPNSlot>().empty = true;
        slot.GetComponent<Image>().enabled = false;
        Hero.GetComponent<HeroStats>().item_DMG = 0f;
        Hero.GetComponent<HeroStats>().str_weapon_type = true;
        Hero.GetComponent<HeroStats>().agl_weapon_type = false;
        Hero.GetComponent<HeroStats>().int_weapon_type = false;
        MainCamera.GetComponent<Items>().fists = true;        //вся зброя в праву руку
        MainCamera.GetComponent<Items>().Stick_of_yura = false;        //вся зброя в праву руку
        MainCamera.GetComponent<Items>().Spear_of_yura = false;        //вся зброя в праву руку
        MainCamera.GetComponent<Items>().Staff_of_yura = false;        //вся зброя в праву руку
       

    }
}
