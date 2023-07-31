using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    public GameObject TextTemplate;          //текстовий шаблон

    public List<GameObject> textItems;        //лист лог

    void Start() {
        textItems = new List<GameObject>();
    }

    public void LogText(string newTextString, Color newColour){

        if(textItems.Count == 5000){                                 //обмеження повідомлень
            GameObject tempItem = textItems[0]; 
            Destroy(tempItem.gameObject); 
            textItems.Remove(tempItem);
        }

        GameObject newText = Instantiate(TextTemplate) as GameObject; 
        newText.SetActive(true); 

        newText.GetComponent<item>().SetText(newTextString, newColour);  
        newText.transform.SetParent(TextTemplate.transform.parent, false);

        textItems.Add(newText.gameObject);
    }
}
