using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XrArm : MonoBehaviour
{
    public GameObject slot;             //відображення хрестика
    public GameObject Hero;
    public GameObject MainCamera;

    void Update()
    {
        if(slot.GetComponent<rArmSlot>().empty == false){
            gameObject.GetComponent<Image>().enabled = true;

        }
        else if(slot.GetComponent<rArmSlot>().empty == true){
            gameObject.GetComponent<Image>().enabled = false;
        }
    }

    public void clear(){
        slot.GetComponent<rArmSlot>().empty = true;
        slot.GetComponent<Image>().enabled = false;
        Hero.GetComponent<HeroStats>().item_armor_rArm = 0f;
        MainCamera.GetComponent<Items>().Shoulder_of_yura_right = false;        //вся броня rArm

    }
}
