using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esc_HUD_script : MonoBehaviour
{
    public GameObject esc_HUD;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            esc_HUD.SetActive(!esc_HUD.activeInHierarchy);
        }
    }

    public void Quit_button(){
        Application.Quit();
    }


}
