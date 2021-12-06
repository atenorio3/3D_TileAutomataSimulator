using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniversalClasses;

public class Demo1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
          float x = 0;
          TA_System currentSystem = Read_XML.loadedSystem;

          foreach (KeyValuePair<string, string> state in currentSystem.returnAllStates())
          {
               GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube); // Generate new cube
               cube.name = state.Key; // Label Cube
               cube.transform.position = new Vector3(x, 0f, 0f); // Place cube

               // Color Cube
               string temp_hex = state.Value;
               int tempR = Convert.ToInt32(temp_hex.Substring(0, 2), 16);
               int tempG = Convert.ToInt32(temp_hex.Substring(2, 2), 16);
               int tempB = Convert.ToInt32(temp_hex.Substring(4, 2), 16);
               Color tempColor = new Color(tempR, tempG, tempB, 0xff);
               cube.GetComponent<Renderer>().material.color = tempColor;

               // Increment x
               x += 2;
          }
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
