using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{

    public Canvas optionsCanvas, creditsCanvas; // Options and credits canvas references.


    // Start is called before the first frame update
    void Start()
    {
        // Set the top canvases to disabled on start to show the main menu:
        optionsCanvas.enabled = false;
        creditsCanvas.enabled = false;
 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Menu UI Events

    // Scene Changing Events

    public void onStartButton() 
    {
        Debug.Log("Loading Testbed");
        SceneManager.LoadScene("Levels");
    }

    public void onExitButton()
    {
        Debug.Log("Quitting App");
        Application.Quit();
    }
}


