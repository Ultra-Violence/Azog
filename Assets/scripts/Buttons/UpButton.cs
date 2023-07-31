using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpButton : MonoBehaviour
{
    public Sprite UpRed;
    public Sprite UpYellow;
    public Sprite UpGreen;
    public GameObject UpBut;

    public bool wall = false;

    private void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "goblin" | other.tag == "dark_goblin"){
            UpBut.GetComponent<Image>().sprite = UpRed;
            UpBut.GetComponent<Image>().enabled = true;
            UpBut.GetComponent<Button>().enabled = true;
            wall = true;
            }
        else if(other.tag == "goblin_seller_quest" | other.tag =="hunter_medicine_quest" | other.tag == "altar" | other.tag == "napis" | other.tag == "deer"){
            UpBut.GetComponent<Image>().sprite = UpYellow;
            UpBut.GetComponent<Image>().enabled = true;
            UpBut.GetComponent<Button>().enabled = true;
            wall = true; 
        }
        else if(other.tag == "chest" | other.tag == "cave"){
            UpBut.GetComponent<Image>().sprite = UpGreen;
            UpBut.GetComponent<Image>().enabled = true;
            UpBut.GetComponent<Button>().enabled = true;
            wall = true;
        }
        else if(other.tag == "wall"){
            wall = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other) {
        UpBut.GetComponent<Image>().enabled = false;
        UpBut.GetComponent<Button>().enabled = false;
        wall = false;
    }
}
