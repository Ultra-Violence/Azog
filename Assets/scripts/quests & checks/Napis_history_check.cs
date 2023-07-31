using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Napis_history_check : MonoBehaviour
{

    public bool napis_quest_end = false;
    public static bool static_napis_quest_end = false;

    public HeroPeaceSkills HeroPeaceSkills;
    public LvlUp LvlUp;

    public GameObject napis_history_check_HUD;
    public GameObject napis_history_check_complited_HUD;
    public GameObject napis_history_check_failed_HUD;

    private void Awake() {
        napis_quest_end = static_napis_quest_end;
    }

    private void Update() {
        static_napis_quest_end = napis_quest_end;
    }

    public void history_check(){
        System.Random random_d20 = new System.Random();
        int random_d20_dice = random_d20.Next(21);

        int result = HeroPeaceSkills.history + random_d20_dice;

        if(result > 6){
            napis_history_check_complited_HUD.SetActive(true);
            LvlUp.exp = LvlUp.exp + 100;
            napis_history_check_HUD.SetActive(false);
        }
        else{ 
            napis_history_check_failed_HUD.SetActive(true);
            napis_history_check_HUD.SetActive(false);
        }
    }

    public void move_away(){
        napis_history_check_HUD.SetActive(false);
        napis_history_check_complited_HUD.SetActive(false);
        napis_history_check_failed_HUD.SetActive(false);
        napis_quest_end = true;
    }
}
