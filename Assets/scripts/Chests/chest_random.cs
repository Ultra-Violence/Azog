using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class chest_random : MonoBehaviour
{
    public Image icon_item;
    public GameObject chest_HUD;
    public InventoryConvas InventoryConvas;

    private string random_item_name;

    List<string> items_list = new List<string>() {"Armor_of_yura", "Boot_of_yura_left", "Boot_of_yura_right", "Helm_of_yura", "Shield_of_yura", "Shoulder_of_yura_left", "Shoulder_of_yura_right"};

    public void open_chest(){

        chest_HUD.SetActive(true);

        System.Random random = new System.Random();  //новий рандом
        int random_Index = random.Next(items_list.Count);  //некст дозволяє брати число від 0 до заданого
        random_item_name = items_list[random_Index];  //обираємо випадковий індекс

        Sprite item_in_chest = Resources.Load <Sprite>("Inventory/items/invicon/"+random_item_name);

        icon_item.sprite = item_in_chest;
    }

    public void item_take_button(){
        InventoryConvas.Add_item_inv_list(random_item_name);
        chest_HUD.SetActive(false);

    }

}
