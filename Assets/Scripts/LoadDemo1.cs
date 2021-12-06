using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UniversalClasses;

// This Demo will render every state from a given system.
public class LoadDemo1 : MonoBehaviour
{
    public void StartSimulation()
     {
          SceneManager.LoadScene(sceneBuildIndex: 1);
     }

}
