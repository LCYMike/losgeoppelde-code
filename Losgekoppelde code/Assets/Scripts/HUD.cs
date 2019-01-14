using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour {

    private Inventory inventory;

    private List<string> inv;

    private void Start()
    {
        inv = new List<string>();
    }

    void Update()
    {

        inv = inventory.GetInv();

        Debug.Log(inv);

    }
}
