using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class HeroAttack : MonoBehaviour
{
    public LayerMask enemyLayers;
    public LayerMask itemsLayers;
    public InventoryConvas inventoryConvas;

    //public bool wallLeft = false;

    //pointAttack
    public Transform attackLeftPos;
    public Transform attackRightPos;
    public Transform attackUpPos;
    public Transform attackDownPos;
    public Transform attackRightDownPos;
    public Transform attackLeftDownPos;
    public Transform attackRightUpPos;
    public Transform attackLeftUpPos;

    public Transform player_place;
    public static Vector3 save_place = new Vector3(0.5f, 0.5f, 0);


    public float attackRange = 0.5f;
    //public float attackArmDamage = 5f;

    public chest_random chest_random;
    public Sprite open_chest_sprite;

    public GameObject goblin_seller_quest_HUD;
    public GameObject goblin_seller_quest_completed_HUD;
    public Goblin_seller_quest goblin_seller_quest;

    public Altar_religion_check Altar_religion_check;
    public GameObject altar_religion_quest_HUD;
    public GameObject altar_religion_quest_complited_HUD;

    public Napis_history_check Napis_history_check;
    public GameObject napis_history_check_HUD;

    public GameObject hunter_medicine_quest_HUD;
    public Hunter_medicine_quest hunter_medicine_quest;

    public GameObject cave_enter_HUD;

    public GameObject deer_survival_check_HUD;
    public GameObject deer1_survival_check_HUD;
    public GameObject deer2_survival_check_HUD;
    public Deer_survival_check Deer_survival_check;  //deer0
    public Deer1_survival_check Deer1_survival_check;
    public Deer2_survival_check Deer2_survival_check;

    public Enemys Enemys;

    public void Awake() {
        player_place.position = save_place;  //збереження позиції між сценами
    }

    public void Update() {
        save_place = player_place.position;

        // Collider2D[] checkWallsLeft = Physics2D.OverlapCircleAll(attackLeftPos.position, attackRange, itemsLayers);

        // foreach (Collider2D walls in checkWallsLeft)
        // {
            
        //     if(checkWallsLeft.Length == 0)
        //         wallLeft = true;

        // }
    }


     public void attackLeft(){

        //Time.timeScale = 1;

        

        Collider2D[] takeItemLeft = Physics2D.OverlapCircleAll(attackLeftPos.position, attackRange, itemsLayers);

        foreach (Collider2D items in takeItemLeft)
        {
            if(items.tag == "item"){
                inventoryConvas.Add_item_inv_list(items.name);
                }
            else if(items.name == "Food"){
                inventoryConvas.Add_food_inv_list(items.name);
                }


        }
        
        Collider2D[] hitEnemiesLeft = Physics2D.OverlapCircleAll(attackLeftPos.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemiesLeft)
        {
            if(enemy.tag == "goblin"){
                SceneManager.LoadScene("Goblin_fight");
                if(enemy.name == "Goblin_quest"){
                    goblin_seller_quest.quest_completed = true;
                    Enemys.goblin_quest_target= false;
                    }
                else if(enemy.name == "Goblin0")
                    Enemys.goblin0= false;
                else if(enemy.name == "Goblin1")
                    Enemys.goblin1= false;
                else if(enemy.name == "Goblin2")
                    Enemys.goblin2= false;
                else if(enemy.name == "Goblin3")
                    Enemys.goblin3 = false;
                    }
            else if (enemy.tag == "dark_goblin")
                SceneManager.LoadScene("Darkgoblin_fight");
                if(enemy.name == "DarkGoblin0")
                    Enemys.dark_goblin0 = false;
            else if (enemy.tag == "goblin_seller_quest" & goblin_seller_quest.quest_taken == false){
                goblin_seller_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "goblin_seller_quest" & goblin_seller_quest.quest_completed == true){
                goblin_seller_quest_completed_HUD.SetActive(true);
                }
            else if (enemy.tag == "hunter_medicine_quest"){
                hunter_medicine_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest1"){
                enemy.GetComponent<chest1>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest2"){
                enemy.GetComponent<chest2>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest3"){
                enemy.GetComponent<chest3>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == false & Altar_religion_check.looking_for_food_gift == false){
                altar_religion_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == true & Altar_religion_check.looking_for_food_gift == true){
                altar_religion_quest_complited_HUD.SetActive(true);
                }
            else if(enemy.tag == "napis" & Napis_history_check.napis_quest_end == false){
                napis_history_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer0" & Deer_survival_check.deer0_quest_end == false){
                deer_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer1" & Deer1_survival_check.deer1_quest_end == false){
                deer1_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer2" & Deer2_survival_check.deer2_quest_end == false){
                deer2_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "cave"){
                cave_enter_HUD.SetActive(true);
            }
        }

        //Invoke("pause", 0.05f);
     }

    public void attackRight(){

        //Time.timeScale = 1;
        
        Collider2D[] takeItemRight = Physics2D.OverlapCircleAll(attackRightPos.position, attackRange, itemsLayers);

        foreach (Collider2D items in takeItemRight)
        {
            if(items.tag == "item"){
                inventoryConvas.Add_item_inv_list(items.name);
                }
            else if(items.name == "Food"){
                inventoryConvas.Add_food_inv_list(items.name);
                }
            

        }

        Collider2D[] hitEnemiesRight = Physics2D.OverlapCircleAll(attackRightPos.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemiesRight)
        {
            if(enemy.tag == "goblin"){
                SceneManager.LoadScene("Goblin_fight");
                if(enemy.name == "Goblin_quest"){
                    goblin_seller_quest.quest_completed = true;
                    Enemys.goblin_quest_target= false;
                    }
                else if(enemy.name == "Goblin0")
                    Enemys.goblin0= false;
                else if(enemy.name == "Goblin1")
                    Enemys.goblin1= false;
                else if(enemy.name == "Goblin2")
                    Enemys.goblin2= false;
                else if(enemy.name == "Goblin3")
                    Enemys.goblin3 = false;
                    }
            else if (enemy.tag == "dark_goblin")
                SceneManager.LoadScene("Darkgoblin_fight");
                if(enemy.name == "DarkGoblin0")
                    Enemys.dark_goblin0 = false;
            else if (enemy.tag == "goblin_seller_quest" & goblin_seller_quest.quest_taken == false){
                goblin_seller_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "goblin_seller_quest" & goblin_seller_quest.quest_completed == true){
                goblin_seller_quest_completed_HUD.SetActive(true);
                }
            else if (enemy.tag == "hunter_medicine_quest"){
                hunter_medicine_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest1"){
                enemy.GetComponent<chest1>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest2"){
                enemy.GetComponent<chest2>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest3"){
                enemy.GetComponent<chest3>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == false & Altar_religion_check.looking_for_food_gift == false){
                altar_religion_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == true & Altar_religion_check.looking_for_food_gift == true){
                altar_religion_quest_complited_HUD.SetActive(true);
                }
            else if(enemy.tag == "napis" & Napis_history_check.napis_quest_end == false){
                napis_history_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer0" & Deer_survival_check.deer0_quest_end == false){
                deer_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer1" & Deer1_survival_check.deer1_quest_end == false){
                deer1_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer2" & Deer2_survival_check.deer2_quest_end == false){
                deer2_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "cave"){
                cave_enter_HUD.SetActive(true);
            }
        }

        //Invoke("pause", 0.05f);
    }

    public void attackUp(){

        //Time.timeScale = 1;

        Collider2D[] takeItemUp = Physics2D.OverlapCircleAll(attackUpPos.position, attackRange, itemsLayers);

        foreach (Collider2D items in takeItemUp)
        {
            if(items.tag == "item"){
                inventoryConvas.Add_item_inv_list(items.name);
                }
            else if(items.name == "Food"){
                inventoryConvas.Add_food_inv_list(items.name);
                }

        }

        Collider2D[] hitEnemiesUp = Physics2D.OverlapCircleAll(attackUpPos.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemiesUp)
        {
            if(enemy.tag == "goblin"){
                SceneManager.LoadScene("Goblin_fight");
                if(enemy.name == "Goblin_quest"){
                    goblin_seller_quest.quest_completed = true;
                    Enemys.goblin_quest_target= false;
                    }
                else if(enemy.name == "Goblin0")
                    Enemys.goblin0= false;
                else if(enemy.name == "Goblin1")
                    Enemys.goblin1= false;
                else if(enemy.name == "Goblin2")
                    Enemys.goblin2= false;
                else if(enemy.name == "Goblin3")
                    Enemys.goblin3 = false;
                    }
            else if (enemy.tag == "dark_goblin")
                SceneManager.LoadScene("Darkgoblin_fight");
                if(enemy.name == "DarkGoblin0")
                    Enemys.dark_goblin0 = false;
            else if (enemy.tag == "goblin_seller_quest" & goblin_seller_quest.quest_taken == false){
                goblin_seller_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "goblin_seller_quest" & goblin_seller_quest.quest_completed == true){
                goblin_seller_quest_completed_HUD.SetActive(true);
                }
            else if (enemy.tag == "hunter_medicine_quest"){
                hunter_medicine_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest1"){
                enemy.GetComponent<chest1>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest2"){
                enemy.GetComponent<chest2>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest3"){
                enemy.GetComponent<chest3>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == false){
                altar_religion_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == false & Altar_religion_check.looking_for_food_gift == false){
                altar_religion_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == true & Altar_religion_check.looking_for_food_gift == true){
                altar_religion_quest_complited_HUD.SetActive(true);
                }
            else if(enemy.tag == "napis" & Napis_history_check.napis_quest_end == false){
                napis_history_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer0" & Deer_survival_check.deer0_quest_end == false){
                deer_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer1" & Deer1_survival_check.deer1_quest_end == false){
                deer1_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer2" & Deer2_survival_check.deer2_quest_end == false){
                deer2_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "cave"){
                cave_enter_HUD.SetActive(true);
            }

        }

        //Invoke("pause", 0.05f);
    }

    public void attackDown(){

        //Time.timeScale = 1;

        Collider2D[] takeItemDown = Physics2D.OverlapCircleAll(attackDownPos.position, attackRange, itemsLayers);

        foreach (Collider2D items in takeItemDown)
        {
            if(items.tag == "item"){
                inventoryConvas.Add_item_inv_list(items.name);
                }
            else if(items.name == "Food"){
                inventoryConvas.Add_food_inv_list(items.name);
                }

        }

        Collider2D[] hitEnemiesDown = Physics2D.OverlapCircleAll(attackDownPos.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemiesDown)
        {
            if(enemy.tag == "goblin"){
                SceneManager.LoadScene("Goblin_fight");
                if(enemy.name == "Goblin_quest"){
                    goblin_seller_quest.quest_completed = true;
                    Enemys.goblin_quest_target= false;
                    }
                else if(enemy.name == "Goblin0")
                    Enemys.goblin0= false;
                else if(enemy.name == "Goblin1")
                    Enemys.goblin1= false;
                else if(enemy.name == "Goblin2")
                    Enemys.goblin2= false;
                else if(enemy.name == "Goblin3")
                    Enemys.goblin3 = false;
                    }
            else if (enemy.tag == "dark_goblin")
                SceneManager.LoadScene("Darkgoblin_fight");
                if(enemy.name == "DarkGoblin0")
                    Enemys.dark_goblin0 = false;
            else if (enemy.tag == "goblin_seller_quest" & goblin_seller_quest.quest_taken == false){
                goblin_seller_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "goblin_seller_quest" & goblin_seller_quest.quest_completed == true){
                goblin_seller_quest_completed_HUD.SetActive(true);
                }
            else if (enemy.tag == "hunter_medicine_quest"){
                hunter_medicine_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest1"){
                enemy.GetComponent<chest1>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest2"){
                enemy.GetComponent<chest2>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest3"){
                enemy.GetComponent<chest3>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == false){
                altar_religion_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == false & Altar_religion_check.looking_for_food_gift == false){
                altar_religion_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == true & Altar_religion_check.looking_for_food_gift == true){
                altar_religion_quest_complited_HUD.SetActive(true);
                }
            else if(enemy.tag == "napis" & Napis_history_check.napis_quest_end == false){
                napis_history_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer0" & Deer_survival_check.deer0_quest_end == false){
                deer_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer1" & Deer1_survival_check.deer1_quest_end == false){
                deer1_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer2" & Deer2_survival_check.deer2_quest_end == false){
                deer2_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "cave"){
                cave_enter_HUD.SetActive(true);
            }
        }

        //Invoke("pause", 0.05f);

    }

    private void OnTriggerEnter2D(Collider2D other) {
        
    }

    public void attackRightDown(){

        //Time.timeScale = 1;

        Collider2D[] takeItemRightDown = Physics2D.OverlapCircleAll(attackRightDownPos.position, attackRange, itemsLayers);

        foreach (Collider2D items in takeItemRightDown)
        {
            if(items.tag == "item"){
                inventoryConvas.Add_item_inv_list(items.name);
                }
            else if(items.name == "Food"){
                inventoryConvas.Add_food_inv_list(items.name);
                }

        }

        Collider2D[] hitEnemiesRightDown = Physics2D.OverlapCircleAll(attackRightDownPos.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemiesRightDown)
        {
            if(enemy.tag == "goblin"){
                SceneManager.LoadScene("Goblin_fight");
                if(enemy.name == "Goblin_quest"){
                    goblin_seller_quest.quest_completed = true;
                    Enemys.goblin_quest_target= false;
                    }
                else if(enemy.name == "Goblin0")
                    Enemys.goblin0= false;
                else if(enemy.name == "Goblin1")
                    Enemys.goblin1= false;
                else if(enemy.name == "Goblin2")
                    Enemys.goblin2= false;
                else if(enemy.name == "Goblin3")
                    Enemys.goblin3 = false;
                    }
            else if (enemy.tag == "dark_goblin")
                SceneManager.LoadScene("Darkgoblin_fight");
                if(enemy.name == "DarkGoblin0")
                    Enemys.dark_goblin0 = false;
            else if (enemy.tag == "goblin_seller_quest" & goblin_seller_quest.quest_taken == false){
                goblin_seller_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "goblin_seller_quest" & goblin_seller_quest.quest_completed == true){
                goblin_seller_quest_completed_HUD.SetActive(true);
                }
            else if (enemy.tag == "hunter_medicine_quest"){
                hunter_medicine_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest1"){
                enemy.GetComponent<chest1>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest2"){
                enemy.GetComponent<chest2>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest3"){
                enemy.GetComponent<chest3>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == false){
                altar_religion_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == false & Altar_religion_check.looking_for_food_gift == false){
                altar_religion_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == true & Altar_religion_check.looking_for_food_gift == true){
                altar_religion_quest_complited_HUD.SetActive(true);
                }
            else if(enemy.tag == "napis" & Napis_history_check.napis_quest_end == false){
                napis_history_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer0" & Deer_survival_check.deer0_quest_end == false){
                deer_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer1" & Deer1_survival_check.deer1_quest_end == false){
                deer1_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer2" & Deer2_survival_check.deer2_quest_end == false){
                deer2_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "cave"){
                cave_enter_HUD.SetActive(true);
            }
        }

        //Invoke("pause", 0.05f);
    }

    public void attackLeftDown(){

        //Time.timeScale = 1;

        Collider2D[] takeItemLeftDown = Physics2D.OverlapCircleAll(attackLeftDownPos.position, attackRange, itemsLayers);

        foreach (Collider2D items in takeItemLeftDown)
        {
            if(items.tag == "item"){
                inventoryConvas.Add_item_inv_list(items.name);
                }
            else if(items.name == "Food"){
                inventoryConvas.Add_food_inv_list(items.name);
                }

        }

        Collider2D[] hitEnemiesLeftDown = Physics2D.OverlapCircleAll(attackLeftDownPos.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemiesLeftDown)
        {
            if(enemy.tag == "goblin"){
                SceneManager.LoadScene("Goblin_fight");
                if(enemy.name == "Goblin_quest"){
                    goblin_seller_quest.quest_completed = true;
                    Enemys.goblin_quest_target= false;
                    }
                else if(enemy.name == "Goblin0")
                    Enemys.goblin0= false;
                else if(enemy.name == "Goblin1")
                    Enemys.goblin1= false;
                else if(enemy.name == "Goblin2")
                    Enemys.goblin2= false;
                else if(enemy.name == "Goblin3")
                    Enemys.goblin3 = false;
                    }
            else if (enemy.tag == "dark_goblin")
                SceneManager.LoadScene("Darkgoblin_fight");
                if(enemy.name == "DarkGoblin0")
                    Enemys.dark_goblin0 = false;
            else if (enemy.tag == "goblin_seller_quest" & goblin_seller_quest.quest_taken == false){
                goblin_seller_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "goblin_seller_quest" & goblin_seller_quest.quest_completed == true){
                goblin_seller_quest_completed_HUD.SetActive(true);
                }
            else if (enemy.tag == "hunter_medicine_quest"){
                hunter_medicine_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest1"){
                enemy.GetComponent<chest1>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest2"){
                enemy.GetComponent<chest2>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest3"){
                enemy.GetComponent<chest3>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == false){
                altar_religion_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == false & Altar_religion_check.looking_for_food_gift == false){
                altar_religion_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == true & Altar_religion_check.looking_for_food_gift == true){
                altar_religion_quest_complited_HUD.SetActive(true);
                }
            else if(enemy.tag == "napis" & Napis_history_check.napis_quest_end == false){
                napis_history_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer0" & Deer_survival_check.deer0_quest_end == false){
                deer_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer1" & Deer1_survival_check.deer1_quest_end == false){
                deer1_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer2" & Deer2_survival_check.deer2_quest_end == false){
                deer2_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "cave"){
                cave_enter_HUD.SetActive(true);
            }
        }

        //Invoke("pause", 0.05f);
    }

    public void attackRightUp(){

        //Time.timeScale = 1;

        Collider2D[] takeItemRightUp = Physics2D.OverlapCircleAll(attackRightUpPos.position, attackRange, itemsLayers);

        foreach (Collider2D items in takeItemRightUp)
        {
            if(items.tag == "item"){
                inventoryConvas.Add_item_inv_list(items.name);
                }
            else if(items.name == "Food"){
                inventoryConvas.Add_food_inv_list(items.name);
                }

        }

        Collider2D[] hitEnemiesRightUp = Physics2D.OverlapCircleAll(attackRightUpPos.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemiesRightUp)
        {
            if(enemy.tag == "goblin"){
                SceneManager.LoadScene("Goblin_fight");
                if(enemy.name == "Goblin_quest"){
                    goblin_seller_quest.quest_completed = true;
                    Enemys.goblin_quest_target= false;
                    }
                else if(enemy.name == "Goblin0")
                    Enemys.goblin0= false;
                else if(enemy.name == "Goblin1")
                    Enemys.goblin1= false;
                else if(enemy.name == "Goblin2")
                    Enemys.goblin2= false;
                else if(enemy.name == "Goblin3")
                    Enemys.goblin3 = false;
                    }
            else if (enemy.tag == "dark_goblin")
                SceneManager.LoadScene("Darkgoblin_fight");
                if(enemy.name == "DarkGoblin0")
                    Enemys.dark_goblin0 = false;
            else if (enemy.tag == "goblin_seller_quest" & goblin_seller_quest.quest_taken == false){
                goblin_seller_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "goblin_seller_quest" & goblin_seller_quest.quest_completed == true){
                goblin_seller_quest_completed_HUD.SetActive(true);
                }
            else if (enemy.tag == "hunter_medicine_quest"){
                hunter_medicine_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest1"){
                enemy.GetComponent<chest1>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest2"){
                enemy.GetComponent<chest2>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest3"){
                enemy.GetComponent<chest3>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == false){
                altar_religion_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == false & Altar_religion_check.looking_for_food_gift == false){
                altar_religion_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == true & Altar_religion_check.looking_for_food_gift == true){
                altar_religion_quest_complited_HUD.SetActive(true);
                }
            else if(enemy.tag == "napis" & Napis_history_check.napis_quest_end == false){
                napis_history_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer0" & Deer_survival_check.deer0_quest_end == false){
                deer_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer1" & Deer1_survival_check.deer1_quest_end == false){
                deer1_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer2" & Deer2_survival_check.deer2_quest_end == false){
                deer2_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "cave"){
                cave_enter_HUD.SetActive(true);
            }
        }

        //Invoke("pause", 0.05f);
    }

    public void attackLefttUp(){

        //Time.timeScale = 1;

        Collider2D[] takeItemLeftUp = Physics2D.OverlapCircleAll(attackLeftUpPos.position, attackRange, itemsLayers);

        foreach (Collider2D items in takeItemLeftUp)
        {
            if(items.tag == "item"){
                inventoryConvas.Add_item_inv_list(items.name);
                }
            else if(items.name == "Food"){
                inventoryConvas.Add_food_inv_list(items.name);
                }

        }

        Collider2D[] hitEnemiesLeftUp = Physics2D.OverlapCircleAll(attackLeftUpPos.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemiesLeftUp)
        {
            if(enemy.tag == "goblin"){
                SceneManager.LoadScene("Goblin_fight");
                if(enemy.name == "Goblin_quest"){
                    goblin_seller_quest.quest_completed = true;
                    Enemys.goblin_quest_target= false;
                    }
                else if(enemy.name == "Goblin0")
                    Enemys.goblin0= false;
                else if(enemy.name == "Goblin1")
                    Enemys.goblin1= false;
                else if(enemy.name == "Goblin2")
                    Enemys.goblin2= false;
                else if(enemy.name == "Goblin3")
                    Enemys.goblin3 = false;
                    }
            else if (enemy.tag == "dark_goblin")
                SceneManager.LoadScene("Darkgoblin_fight");
                if(enemy.name == "DarkGoblin0")
                    Enemys.dark_goblin0 = false;
            else if (enemy.tag == "goblin_seller_quest" & goblin_seller_quest.quest_taken == false){
                goblin_seller_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "goblin_seller_quest" & goblin_seller_quest.quest_completed == true){
                goblin_seller_quest_completed_HUD.SetActive(true);
                }
            else if (enemy.tag == "hunter_medicine_quest"){
                hunter_medicine_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest1"){
                enemy.GetComponent<chest1>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest2"){
                enemy.GetComponent<chest2>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "chest" & enemy.GetComponent<SpriteRenderer>().sprite.name == "close_chest" & enemy.name == "chest3"){
                enemy.GetComponent<chest3>().bool_chest = true;
                chest_random.open_chest();
            }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == false){
                altar_religion_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == false & Altar_religion_check.looking_for_food_gift == false){
                altar_religion_quest_HUD.SetActive(true);
                }
            else if (enemy.tag == "altar" & Altar_religion_check.altar_quest_end == true & Altar_religion_check.looking_for_food_gift == true){
                altar_religion_quest_complited_HUD.SetActive(true);
                }
            else if(enemy.tag == "napis" & Napis_history_check.napis_quest_end == false){
                napis_history_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer0" & Deer_survival_check.deer0_quest_end == false){
                deer_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer1" & Deer1_survival_check.deer1_quest_end == false){
                deer1_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "deer" & enemy.name == "Deer2" & Deer2_survival_check.deer2_quest_end == false){
                deer2_survival_check_HUD.SetActive(true);
            }
            else if(enemy.tag == "cave"){
                cave_enter_HUD.SetActive(true);
            }
        }

        //Invoke("pause", 0.05f);
    }

    // void pause(){

    //     Time.timeScale = 0;
    // }

}
