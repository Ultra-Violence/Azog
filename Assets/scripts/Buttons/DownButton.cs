using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DownButton : MonoBehaviour
{
    public Sprite DownRed;
    public Sprite DownYellow;
    public Sprite DownGreen;
    public GameObject DownBut;

    public bool wall = false;

    private void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "goblin" | other.tag == "dark_goblin"){
            DownBut.GetComponent<Image>().sprite = DownRed;
            DownBut.GetComponent<Image>().enabled = true;
            DownBut.GetComponent<Button>().enabled = true;
            wall = true;
            }
        else if(other.tag == "goblin_seller_quest" | other.tag =="hunter_medicine_quest" | other.tag == "altar" | other.tag == "napis" | other.tag == "deer"){
            DownBut.GetComponent<Image>().sprite = DownYellow;
            DownBut.GetComponent<Image>().enabled = true;
            DownBut.GetComponent<Button>().enabled = true;
            wall = true; 
        }
        else if(other.tag == "chest" | other.tag == "cave"){
            DownBut.GetComponent<Image>().sprite = DownGreen;
            DownBut.GetComponent<Image>().enabled = true;
            DownBut.GetComponent<Button>().enabled = true;
            wall = true;
        }
        else if(other.tag == "wall"){
            wall = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other) {
        DownBut.GetComponent<Image>().enabled = false;
        DownBut.GetComponent<Button>().enabled = false;
        wall = false;
    }
}
