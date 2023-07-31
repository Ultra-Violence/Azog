using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDHP : MonoBehaviour
{
    public HeroStats Hero;
    public Slider HP_bar;

    void Update()
    {
        HP_bar.maxValue = Hero.HP_max;
        HP_bar.value = Hero.HP_rn;
    }
}
