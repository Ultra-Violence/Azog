using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroEffects : MonoBehaviour
{
    public bool x3_head_damage = false;
    public bool x1_5_body_damage = false;

    static public bool static_x3_head_damage = false;
    static public bool static_x1_5_body_damage = false;

    private void Awake() {
        x3_head_damage = static_x3_head_damage;
        x1_5_body_damage = static_x1_5_body_damage;

    }

    private void Update() {
        static_x3_head_damage = x3_head_damage;
        static_x1_5_body_damage = x1_5_body_damage;
    }

}
