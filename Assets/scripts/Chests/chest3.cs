using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class chest3 : MonoBehaviour
{
    public Sprite open_chest_sprite;
    public Sprite close_chest_sprite;

    public bool bool_chest = false;
    public static bool static_bool_chest = false;

    private void Awake() {
        bool_chest = static_bool_chest;
    }

    void Update()
    {
        static_bool_chest = bool_chest;

        if(SceneManager.GetActiveScene().name == "SampleScene")
            if(bool_chest == false)
                gameObject.GetComponent<SpriteRenderer>().sprite = close_chest_sprite;
            else if(bool_chest == true)
                gameObject.GetComponent<SpriteRenderer>().sprite = open_chest_sprite;
    }
}
