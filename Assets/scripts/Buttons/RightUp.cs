using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightUp : MonoBehaviour
{
    public Sprite RightUpRed;
    public Sprite RightUpYellow;
    public Sprite RightUpGreen;
    public GameObject RightUpBut;

    public bool wall = false;

    private void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "goblin" | other.tag == "dark_goblin"){
            RightUpBut.GetComponent<Image>().sprite = RightUpRed;
            RightUpBut.GetComponent<Image>().enabled = true;
            RightUpBut.GetComponent<Button>().enabled = true;
            wall = true;
            }
        else if(other.tag == "goblin_seller_quest" | other.tag =="hunter_medicine_quest" | other.tag == "altar" | other.tag == "napis" | other.tag == "deer"){
            RightUpBut.GetComponent<Image>().sprite = RightUpYellow;
            RightUpBut.GetComponent<Image>().enabled = true;
            RightUpBut.GetComponent<Button>().enabled = true;
            wall = true; 
        }
        else if(other.tag == "chest" | other.tag == "cave"){
            RightUpBut.GetComponent<Image>().sprite = RightUpGreen;
            RightUpBut.GetComponent<Image>().enabled = true;
            RightUpBut.GetComponent<Button>().enabled = true;
            wall = true;
        }
        else if(other.tag == "wall"){
            wall = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other) {
        RightUpBut.GetComponent<Image>().enabled = false;
        RightUpBut.GetComponent<Button>().enabled = false;
        wall = false;
    }
}
