using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XlWPN : MonoBehaviour
{
    public GameObject slot;             //відображення хрестика
    public GameObject Hero;
    public GameObject MainCamera;

    void Update()
    {
        if(slot.GetComponent<lWPNSlot>().empty == false){
            gameObject.GetComponent<Image>().enabled = true;

        }
        else if(slot.GetComponent<lWPNSlot>().empty == true){
            gameObject.GetComponent<Image>().enabled = false;
        }
    }

    public void clear(){
        slot.GetComponent<lWPNSlot>().empty = true;
        slot.GetComponent<Image>().enabled = false;
        Hero.GetComponent<HeroStats>().plus_armor -= 1;
        MainCamera.GetComponent<Items>().Shield_of_yura = false;        //вся зброя в ліву руку

    }
}
