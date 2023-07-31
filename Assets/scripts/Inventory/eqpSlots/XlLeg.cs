using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XlLeg : MonoBehaviour
{
    public GameObject slot;             //відображення хрестика
    public GameObject Hero;
    public GameObject MainCamera;

    void Update()
    {
        if(slot.GetComponent<lLegSlot>().empty == false){
            gameObject.GetComponent<Image>().enabled = true;

        }
        else if(slot.GetComponent<lLegSlot>().empty == true){
            gameObject.GetComponent<Image>().enabled = false;
        }
    }

    public void clear(){
        slot.GetComponent<lLegSlot>().empty = true;
        slot.GetComponent<Image>().enabled = false;
        Hero.GetComponent<HeroStats>().item_armor_lLeg = 0f;
        MainCamera.GetComponent<Items>().Boot_of_yura_left = false;        //вся броня

    }
}
