using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftUp : MonoBehaviour
{
    public Sprite LeftUpRed;
    public Sprite LeftUpYellow;
    public Sprite LeftUpGreen;
    public GameObject LeftUpBut;

    public bool wall = false;

    private void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "goblin" | other.tag == "dark_goblin"){
            LeftUpBut.GetComponent<Image>().sprite = LeftUpRed;
            LeftUpBut.GetComponent<Image>().enabled = true;
            LeftUpBut.GetComponent<Button>().enabled = true;
            wall = true;
            }
        else if(other.tag == "goblin_seller_quest" | other.tag =="hunter_medicine_quest" | other.tag == "altar" | other.tag == "napis" | other.tag == "deer"){
            LeftUpBut.GetComponent<Image>().sprite = LeftUpYellow;
            LeftUpBut.GetComponent<Image>().enabled = true;
            LeftUpBut.GetComponent<Button>().enabled = true;
            wall = true; 
        }
        else if(other.tag == "chest" | other.tag == "cave"){
            LeftUpBut.GetComponent<Image>().sprite = LeftUpGreen;
            LeftUpBut.GetComponent<Image>().enabled = true;
            LeftUpBut.GetComponent<Button>().enabled = true;
            wall = true;
        }
        else if(other.tag == "wall"){
            wall = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other) {
        LeftUpBut.GetComponent<Image>().enabled = false;
        LeftUpBut.GetComponent<Button>().enabled = false;
        wall = false;
    }
}
