using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    private List<string> inv;

    private int max = 5;

    private void Start()
    {
        inv = new List<string>();
    }

    public List<string> GetInv()
    {
        return inv;
    }

    public void Add(string item)
    {
        if (inv.Count <= max)
        {
            inv.Add(item);
            Debug.Log("Added : " + item);
        }
        else
        {
            Debug.Log("Error : Inventory Full");
            Debug.Log("Could not add : " + item);
        }
    }

    public void Remove(string item)
    {
        inv.Remove(item);
        Debug.Log("Removed : " + item);
    }

}
