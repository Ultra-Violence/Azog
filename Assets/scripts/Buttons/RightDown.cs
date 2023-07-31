using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightDown : MonoBehaviour
{
    public Sprite RightDownRed;
    public Sprite RightDownYellow;
    public Sprite RightDownGreen;
    public GameObject RightDownBut;

    public bool wall = false;

    private void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "goblin" | other.tag == "dark_goblin"){
            RightDownBut.GetComponent<Image>().sprite = RightDownRed;
            RightDownBut.GetComponent<Image>().enabled = true;
            RightDownBut.GetComponent<Button>().enabled = true;
            wall = true;
            }
        else if(other.tag == "goblin_seller_quest" | other.tag =="hunter_medicine_quest" | other.tag == "altar" | other.tag == "napis" | other.tag == "deer"){
            RightDownBut.GetComponent<Image>().sprite = RightDownYellow;
            RightDownBut.GetComponent<Image>().enabled = true;
            RightDownBut.GetComponent<Button>().enabled = true;
            wall = true; 
        }
        else if(other.tag == "chest" | other.tag == "cave"){
            RightDownBut.GetComponent<Image>().sprite = RightDownGreen;
            RightDownBut.GetComponent<Image>().enabled = true;
            RightDownBut.GetComponent<Button>().enabled = true;
            wall = true;
        }
        else if(other.tag == "wall"){
            wall = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other) {
        RightDownBut.GetComponent<Image>().enabled = false;
        RightDownBut.GetComponent<Button>().enabled = false;
        wall = false;
    }
}
