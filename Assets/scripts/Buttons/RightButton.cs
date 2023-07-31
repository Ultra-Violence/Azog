using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightButton : MonoBehaviour
{
    public Sprite RightRed;
    public Sprite RightYellow;
    public Sprite RightGreen;
    public GameObject RightBut;

    public bool wall = false;

    private void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "goblin" | other.tag == "dark_goblin"){
            RightBut.GetComponent<Image>().sprite = RightRed;
            RightBut.GetComponent<Image>().enabled = true;
            RightBut.GetComponent<Button>().enabled = true;
            wall = true;
            }
        else if(other.tag == "goblin_seller_quest" | other.tag =="hunter_medicine_quest" | other.tag == "altar" | other.tag == "napis" | other.tag == "deer"){
            RightBut.GetComponent<Image>().sprite = RightYellow;
            RightBut.GetComponent<Image>().enabled = true;
            RightBut.GetComponent<Button>().enabled = true;
            wall = true; 
        }
        else if(other.tag == "chest" | other.tag == "cave"){
            RightBut.GetComponent<Image>().sprite = RightGreen;
            RightBut.GetComponent<Image>().enabled = true;
            RightBut.GetComponent<Button>().enabled = true;
            wall = true;
        }
        else if(other.tag == "wall"){
            wall = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other) {
        RightBut.GetComponent<Image>().enabled = false;
        RightBut.GetComponent<Button>().enabled = false;
        wall = false;
    }
}

