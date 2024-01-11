using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    //Inventory array
    private string[] inventoryArray = new[] { "Sword", "Shield", "Potion" };
    
    //move elements in the array to list
    private List<string> inventoryList;



    // Start is called before the first frame update
    void Start()
    {
        inventoryList = new List<string>(inventoryArray);
        DisplayInventory();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            inventoryList.Add("Helmet");
            DisplayInventory();
        }
        
        else if (Input.GetKeyDown(KeyCode.R))
        {
            inventoryList.Remove("Sword");
            DisplayInventory();
        }
    }

    void DisplayInventory()
    {
        int i = 1;
        Debug.Log("Inventory: ");
        foreach (var item in inventoryList)
        {
            Debug.Log($"{i++}. {item}");
        }
    }
}
