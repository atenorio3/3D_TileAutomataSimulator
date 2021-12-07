using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
     private float MOVESPEED = 5f;
     private float ROTATIONSPEED = 3f;
     private float yaw = 0f;
     private float pitch = 0f;

     private void Start()
     {
          Cursor.visible = false;
     }
     // Update is called once per frame
     void Update()
    {
          // Snap Camera back to center
          if (Input.GetKey(KeyCode.Space))
          {
               transform.position = new Vector3(0f, 1f, -10f);
               yaw = 0f;
               pitch = 0f;
               transform.eulerAngles = new Vector3(pitch, yaw, 0f);
          }
          // WASD Controls
          if (Input.GetKey(KeyCode.W))
          {
               transform.position += transform.forward * MOVESPEED * Time.deltaTime;
          }
          if (Input.GetKey(KeyCode.A))
          {
               transform.position -= transform.right * MOVESPEED * Time.deltaTime;
          }
          if (Input.GetKey(KeyCode.S))
          {
               transform.position -= transform.forward * MOVESPEED * Time.deltaTime;
          }
          if (Input.GetKey(KeyCode.D))
          {
               transform.position += transform.right * MOVESPEED * Time.deltaTime;
          }
          if (Input.GetKey(KeyCode.Q))
          {
               transform.position -= transform.up * MOVESPEED * Time.deltaTime;
          }
          if (Input.GetKey(KeyCode.E))
          {
               transform.position += transform.up * MOVESPEED * Time.deltaTime;
          }

          // Camera Rotation
          if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
          {
               yaw += ROTATIONSPEED * Input.GetAxis("Mouse X");
               pitch -= ROTATIONSPEED * Input.GetAxis("Mouse Y");

               transform.eulerAngles = new Vector3(pitch, yaw, 0f);
          }
    }
}
