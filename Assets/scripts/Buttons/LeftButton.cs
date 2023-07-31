using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftButton : MonoBehaviour
{
    public Sprite LeftRed;
    public Sprite LeftYellow;
    public Sprite LeftGreen;
    public GameObject LeftBut;

    public bool wall = false;

    private void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "goblin" | other.tag == "dark_goblin"){
            LeftBut.GetComponent<Image>().sprite = LeftRed;
            LeftBut.GetComponent<Image>().enabled = true;
            LeftBut.GetComponent<Button>().enabled = true;
            wall = true;
            }
        else if(other.tag == "goblin_seller_quest" | other.tag =="hunter_medicine_quest" | other.tag == "altar" | other.tag == "napis" | other.tag == "deer"){
            LeftBut.GetComponent<Image>().sprite = LeftYellow;
            LeftBut.GetComponent<Image>().enabled = true;
            LeftBut.GetComponent<Button>().enabled = true;
            wall = true; 
        }
        else if(other.tag == "chest" | other.tag == "cave"){
            LeftBut.GetComponent<Image>().sprite = LeftGreen;
            LeftBut.GetComponent<Image>().enabled = true;
            LeftBut.GetComponent<Button>().enabled = true;
            wall = true;
        }
        else if(other.tag == "wall"){
            wall = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other) {
        LeftBut.GetComponent<Image>().enabled = false;
        LeftBut.GetComponent<Button>().enabled = false;
        wall = false;
    }
}

