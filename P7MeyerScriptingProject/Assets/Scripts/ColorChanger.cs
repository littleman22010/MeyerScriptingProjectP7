using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Keycode.R))
    
            GetComponent<Renderer>().material.Color = Color.red;
    {  
    if (input.GetKeyDown(KeyCode.G))
            GetComponent<Renderer>().material.color = Color.green;
    }

        {
            if (input.GetKeyDown(Keycode.B))
                getcomponent<renderer>().material.color = Color.blue
        }
}
