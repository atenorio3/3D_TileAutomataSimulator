using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UniversalClasses;

public class Demo1 : MonoBehaviour
{
     public GameObject tile;
     // Start is called before the first frame update
     void Start()
    {
          float x = 0f;
          TA_System currentSystem = Read_XML.loadedSystem;

          foreach (KeyValuePair<string, string> state in currentSystem.returnAllStates())
          {
               GameObject currentTile = Instantiate(tile, new Vector3(x, 0f, 0f), Quaternion.identity);

               // Apply labels 
               for(int i = 0; i < 6; i++)
               {
                    TMP_Text currentLabel = currentTile.transform.GetChild(i).GetComponent<TMP_Text>();
                    currentLabel.SetText(state.Key);
               }
               // Color tile
               string temp_hex = state.Value;
               int tempR = Convert.ToInt32(temp_hex.Substring(0, 2), 16);
               int tempG = Convert.ToInt32(temp_hex.Substring(2, 2), 16);
               int tempB = Convert.ToInt32(temp_hex.Substring(4, 2), 16);

               Color tempColor = new Color(tempR, tempG, tempB, 0xff);
               Transform currentTileBody = currentTile.transform.GetChild(6);
               currentTileBody.GetComponent<Renderer>().material.color = tempColor;

               // Color tile frames
               for (int i = 0; i < 12; i++)
               {
                    Transform currentFrame = currentTileBody.transform.GetChild(i);
                    currentFrame.GetComponent<Renderer>().material.color = Color.black;
               }

               // Increment x
               x += 1;
          }

          x = 0f;
          foreach (KeyValuePair<string, string> state in currentSystem.returnInitialStates())
          {
               GameObject currentTile = Instantiate(tile, new Vector3(x, -1f, 0f), Quaternion.identity);

               // Apply labels 
               for (int i = 0; i < 6; i++)
               {
                    TMP_Text currentLabel = currentTile.transform.GetChild(i).GetComponent<TMP_Text>();
                    currentLabel.SetText(state.Key);
               }
               // Color tile body
               string temp_hex = state.Value;
               int tempR = Convert.ToInt32(temp_hex.Substring(0, 2), 16);
               int tempG = Convert.ToInt32(temp_hex.Substring(2, 2), 16);
               int tempB = Convert.ToInt32(temp_hex.Substring(4, 2), 16);

               Color tempColor = new Color(tempR, tempG, tempB, 0xff);
               Transform currentTileBody = currentTile.transform.GetChild(6);
               currentTileBody.GetComponent<Renderer>().material.color = tempColor;

               // Color tile frames
               for (int i = 0; i < 12; i++)
               {
                    Transform currentFrame = currentTileBody.transform.GetChild(i);
                    currentFrame.GetComponent<Renderer>().material.color = Color.black;
               }

               // Increment x
               x += 1;
          }

          x = 0f;
          foreach (KeyValuePair<string, string> state in currentSystem.returnSeedStates())
          {
               GameObject currentTile = Instantiate(tile, new Vector3(x, -2f, 0f), Quaternion.identity);

               // Apply labels 
               for (int i = 0; i < 6; i++)
               {
                    TMP_Text currentLabel = currentTile.transform.GetChild(i).GetComponent<TMP_Text>();
                    currentLabel.SetText(state.Key);
               }
               // Color tile
               string temp_hex = state.Value;
               int tempR = Convert.ToInt32(temp_hex.Substring(0, 2), 16);
               int tempG = Convert.ToInt32(temp_hex.Substring(2, 2), 16);
               int tempB = Convert.ToInt32(temp_hex.Substring(4, 2), 16);

               Color tempColor = new Color(tempR, tempG, tempB, 0xff);
               Transform currentTileBody = currentTile.transform.GetChild(6);
               currentTileBody.GetComponent<Renderer>().material.color = tempColor;

               // Color tile frames
               for (int i = 0; i < 12; i++)
               {
                    Transform currentFrame = currentTileBody.transform.GetChild(i);
                    currentFrame.GetComponent<Renderer>().material.color = Color.black;
               }

               // Increment x
               x += 1;
          }
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
