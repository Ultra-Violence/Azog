using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button Start_game;

    public void startstart(){
        SceneManager.LoadScene(1);
    }
}
