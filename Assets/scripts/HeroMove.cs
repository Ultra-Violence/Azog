using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    public RightButton right;
    public LeftButton left;
    public UpButton up;
    public DownButton down;

    public RightDown right_down;
    public LeftDown left_down;
    public RightUp right_up;
    public LeftUp left_up;

    private Rigidbody2D rb;

    public GameObject chest_loot_HUD;

    public Goblin_seller_quest Goblin_seller_quest;
    public Hunter_medicine_quest Hunter_medicine_quest;
    public Altar_religion_check Altar_religion_check;
    public Napis_history_check Napis_history_check;
    public Deer_survival_check Deer_survival_check;
    public Deer1_survival_check Deer1_survival_check;
    public Deer2_survival_check Deer2_survival_check; 

    public GameObject cave_enter_HUD; 

    public bool delay_bool = false;





    private void Awake() {
        Time.timeScale = 1;
    }

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    
    private void Update() {

        rb.velocity = new Vector2(0, 0);
        if(Goblin_seller_quest.goblin_seller_quest_HUD.activeInHierarchy == false & Goblin_seller_quest.goblin_seller_quest_completed_HUD.activeInHierarchy == false & Hunter_medicine_quest.hunter_medicine_quest_HUD.activeInHierarchy == false & Hunter_medicine_quest.hunter_medicine_quest_complited_HUD.activeInHierarchy == false & Hunter_medicine_quest.hunter_medicine_quest_failed_HUD.activeInHierarchy == false & Hunter_medicine_quest.hunter_medicine_quest_ignore_HUD.activeInHierarchy == false & chest_loot_HUD.activeInHierarchy == false & Altar_religion_check.altar_religion_quest_HUD.activeInHierarchy == false & Altar_religion_check.altar_religion_quest_complited_HUD.activeInHierarchy == false & Altar_religion_check.altar_religion_quest_failed_HUD.activeInHierarchy == false & Altar_religion_check.altar_religion_quest_gift_HUD.activeInHierarchy == false & Napis_history_check.napis_history_check_HUD.activeInHierarchy == false & Napis_history_check.napis_history_check_complited_HUD.activeInHierarchy == false & Napis_history_check.napis_history_check_failed_HUD.activeInHierarchy == false & Deer_survival_check.deer_survival_check_HUD.activeInHierarchy == false & Deer_survival_check.deer_survival_check_complited_HUD.activeInHierarchy == false & Deer_survival_check.deer_survival_check_failed_HUD.activeInHierarchy == false & Deer1_survival_check.deer_survival_check_HUD.activeInHierarchy == false & Deer1_survival_check.deer_survival_check_complited_HUD.activeInHierarchy == false & Deer1_survival_check.deer_survival_check_failed_HUD.activeInHierarchy == false & Deer2_survival_check.deer_survival_check_HUD.activeInHierarchy == false & Deer2_survival_check.deer_survival_check_complited_HUD.activeInHierarchy == false & Deer2_survival_check.deer_survival_check_failed_HUD.activeInHierarchy == false & cave_enter_HUD.activeInHierarchy == false){

            if(Input.GetKeyDown(KeyCode.A)){
                if(left.wall == false & delay_bool == false){
                Time.timeScale = 1;
                transform.position = transform.position + new Vector3(-1, 0, 0);
                delay_bool = true;
                Invoke("delay", 0.05f);
                }
                }

            else if(Input.GetKeyDown(KeyCode.D)){
                if(right.wall == false & delay_bool == false){
                Time.timeScale = 1;
                transform.position = transform.position + new Vector3(+1, 0, 0);
                delay_bool = true;
                Invoke("delay", 0.05f);
                }
                }

            else if(Input.GetKeyDown(KeyCode.W)){
                if(up.wall == false & delay_bool == false){
                Time.timeScale = 1;
                transform.position = transform.position + new Vector3(0, +1, 0);
                delay_bool = true;
                Invoke("delay", 0.05f);
                }
                }

            else if(Input.GetKeyDown(KeyCode.S)){
                if(down.wall == false & delay_bool == false){
                Time.timeScale = 1;
                transform.position = transform.position + new Vector3(0, -1, 0);
                delay_bool = true;
                Invoke("delay", 0.05f);
                }
                }
        } 
    }

    public void delay(){
        delay_bool = false;
    }


}
