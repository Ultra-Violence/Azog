using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftDown : MonoBehaviour
{
    public Sprite LeftDownRed;
    public Sprite LeftDownYellow;
    public Sprite LeftDownGreen;
    public GameObject LeftDownBut;

    public bool wall = false;

    private void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "goblin" | other.tag == "dark_goblin"){
            LeftDownBut.GetComponent<Image>().sprite = LeftDownRed;
            LeftDownBut.GetComponent<Image>().enabled = true;
            LeftDownBut.GetComponent<Button>().enabled = true;
            wall = true;
            }
        else if(other.tag == "goblin_seller_quest" | other.tag =="hunter_medicine_quest" | other.tag == "altar" | other.tag == "napis" | other.tag == "deer"){
            LeftDownBut.GetComponent<Image>().sprite = LeftDownYellow;
            LeftDownBut.GetComponent<Image>().enabled = true;
            LeftDownBut.GetComponent<Button>().enabled = true;
            wall = true; 
        }
        else if(other.tag == "chest" | other.tag == "cave"){
            LeftDownBut.GetComponent<Image>().sprite = LeftDownGreen;
            LeftDownBut.GetComponent<Image>().enabled = true;
            LeftDownBut.GetComponent<Button>().enabled = true;
            wall = true;
        }
        else if(other.tag == "wall"){
            wall = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other) {
        LeftDownBut.GetComponent<Image>().enabled = false;
        LeftDownBut.GetComponent<Button>().enabled = false;
        wall = false;
    }
}
