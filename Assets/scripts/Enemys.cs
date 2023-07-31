using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemys : MonoBehaviour
{
    public GameObject Goblin_quest_target;
    public GameObject Goblin0;
    public GameObject Goblin1;
    public GameObject Goblin2;
    public GameObject Goblin3;

    public GameObject DarkGoblin0;

    public bool goblin_quest_target = true;
    public bool goblin0 = true;
    public bool goblin1 = true;
    public bool goblin2 = true;
    public bool goblin3 = true;
    public bool dark_goblin0 = true;

    public static bool static_goblin_quest_target = true;
    public static bool static_goblin0 = true;
    public static bool static_goblin1 = true;
    public static bool static_goblin2 = true;
    public static bool static_goblin3 = true;
    public static bool static_dark_goblin0 = true;

    private void Awake() {
        goblin_quest_target = static_goblin_quest_target;
        goblin0 = static_goblin0;
        goblin1 = static_goblin1;
        goblin2 = static_goblin2;
        goblin3 = static_goblin3;

        dark_goblin0 = static_dark_goblin0;
    }

    private void Update() {
        static_goblin_quest_target = goblin_quest_target;
        static_goblin0 = goblin0;
        static_goblin1 = goblin1;
        static_goblin2 = goblin2;
        static_goblin3 = goblin3;

        static_dark_goblin0 = dark_goblin0;

        if(SceneManager.GetActiveScene().name == "SampleScene"){
            if(goblin_quest_target == true)
                Goblin_quest_target.SetActive(true);
            else 
                Goblin_quest_target.SetActive(false);

            if(goblin0 == true)
                Goblin0.SetActive(true);
            else 
                Goblin0.SetActive(false);

            if(goblin1 == true)
                Goblin1.SetActive(true);
            else 
                Goblin1.SetActive(false);

            if(goblin2 == true)
                Goblin2.SetActive(true);
            else 
                Goblin2.SetActive(false);

            if(goblin3 == true)
                Goblin3.SetActive(true);
            else 
                Goblin3.SetActive(false);
            
            if(dark_goblin0 == true)
                DarkGoblin0.SetActive(true);
            else 
                DarkGoblin0.SetActive(false);
            }
    }
}

