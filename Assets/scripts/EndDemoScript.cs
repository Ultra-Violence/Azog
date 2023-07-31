using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndDemoScript : MonoBehaviour
{
    public void Start_menu_button(){
        SceneManager.LoadScene("Menu");
    }
}
