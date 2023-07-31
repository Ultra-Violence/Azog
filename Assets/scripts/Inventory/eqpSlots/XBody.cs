using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XBody : MonoBehaviour
{
    public GameObject slot;             //відображення хрестика
    public GameObject Hero;
    public GameObject MainCamera;

    void Update()
    {
        if(slot.GetComponent<BodySlot>().empty == false){
            gameObject.GetComponent<Image>().enabled = true;

        }
        else if(slot.GetComponent<BodySlot>().empty == true){
            gameObject.GetComponent<Image>().enabled = false;
        }
    }

    public void clear(){
        slot.GetComponent<BodySlot>().empty = true;
        slot.GetComponent<Image>().enabled = false;
        Hero.GetComponent<HeroStats>().item_armor_body = 0f;
        MainCamera.GetComponent<Items>().Armor_of_yura = false;        //вся броня

    }
}
