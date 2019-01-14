using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour {

    private List<string> inv;

    private void Start()
    {
        inv = new List<string>();
    }

    void Update()
    {

        Debug.Log(inv);

    }
}
