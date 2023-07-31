using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewTraima : MonoBehaviour
{
    public HeroStats Hero;
    public Image concossion;
    public Image pierced_skull;

    public Image clavicle_fracture_right;
    public Image elbow_fracture_right;
    public Image hand_fracture_right;
    public Image thumb_right;
    public Image index_right;
    public Image middle_right;
    public Image ring_right;
    public Image little_right;

    public Image clavicle_fracture_left;
    public Image elbow_fracture_left;
    public Image hand_fracture_left;
    public Image thumb_left;
    public Image index_left;
    public Image middle_left;
    public Image ring_left;
    public Image little_left;

    public Image foot_fracture_right;
    public Image knee_fracture_right;

    public Image foot_fracture_left;
    public Image knee_fracture_left;


    private Color on;
    private Color off;

    private void Start() {
        off = new Color(0.25f, 0.25f, 0.25f);
        on = new Color(1f, 1f, 1f);
    }

    void Update()
    {
        if(Hero.trauma_concussion == true)
            concossion.color = on;
        else
            concossion.color = off;

        if(Hero.trauma_pierced_skull == true)
            pierced_skull.color = on;
        else
            pierced_skull.color = off;




        if(Hero.trauma_rClavicle_fracture == true)
            clavicle_fracture_right.color = on;
        else
            clavicle_fracture_right.color = off;

        if(Hero.trauma_rElbow_fracture == true)
            elbow_fracture_right.color = on;
        else
            elbow_fracture_right.color = off;

        if(Hero.trauma_rHand_fracture == true)
            hand_fracture_right.color = on;
        else
            hand_fracture_right.color = off;

        if(Hero.trauma_severed_rThumb == true)
            thumb_right.color = on;
        else
            thumb_right.color = off;

        if(Hero.trauma_severed_rIndex == true)
            index_right.color = on;
        else
            index_right.color = off;

        if(Hero.trauma_severed_rMiddle == true)
            middle_right.color = on;
        else
            middle_right.color = off;

        if(Hero.trauma_severed_rRing == true)
            ring_right.color = on;
        else
            ring_right.color = off;

        if(Hero.trauma_severed_rLittle == true)
            little_right.color = on;
        else
            little_right.color = off;



        if(Hero.trauma_lClavicle_fracture == true)
            clavicle_fracture_left.color = on;
        else
            clavicle_fracture_left.color = off;

        if(Hero.trauma_lElbow_fracture == true)
            elbow_fracture_left.color = on;
        else
            elbow_fracture_left.color = off;

        if(Hero.trauma_lHand_fracture == true)
            hand_fracture_left.color = on;
        else
            hand_fracture_left.color = off;

        if(Hero.trauma_severed_lThumb == true)
            thumb_left.color = on;
        else
            thumb_left.color = off;

        if(Hero.trauma_severed_lIndex == true)
            index_left.color = on;
        else
            index_left.color = off;

        if(Hero.trauma_severed_lMiddle == true)
            middle_left.color = on;
        else
            middle_left.color = off;

        if(Hero.trauma_severed_lRing == true)
            ring_left.color = on;
        else
            ring_left.color = off;

        if(Hero.trauma_severed_lLittle == true)
            little_left.color = on;
        else
            little_left.color = off;



        if(Hero.trauma_rFoot_fracture == true)
            foot_fracture_right.color = on;
        else
            foot_fracture_right.color = off;

        if(Hero.trauma_rKnee_fracture == true)
            knee_fracture_right.color = on;
        else
            knee_fracture_right.color = off;



        if(Hero.trauma_lFoot_fracture == true)
            foot_fracture_left.color = on;
        else
            foot_fracture_left.color = off;

        if(Hero.trauma_lKnee_fracture == true)
            knee_fracture_left.color = on;
        else
            knee_fracture_left.color = off;


        
    }
}
