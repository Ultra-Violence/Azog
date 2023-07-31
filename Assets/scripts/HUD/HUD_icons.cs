using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD_icons : MonoBehaviour
{
    public GameObject inventary_HUD;
    public GameObject heal_HUD;
    public GameObject lvl_HUD;

    public void inventary_button()
    {
        inventary_HUD.SetActive(!inventary_HUD.activeInHierarchy);
    }

    public void heal_button()
    {
        heal_HUD.SetActive(!heal_HUD.activeInHierarchy);
    }

    public void lvl_button()
    {
        lvl_HUD.SetActive(!lvl_HUD.activeInHierarchy);
    }
}
