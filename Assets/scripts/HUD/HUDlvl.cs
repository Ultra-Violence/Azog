using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDlvl : MonoBehaviour
{
public GameObject Hero;

    void Update()
    {
        gameObject.GetComponent<Text>().text = Hero.GetComponent<LvlUp>().lvl_hero.ToString();
    }
}
