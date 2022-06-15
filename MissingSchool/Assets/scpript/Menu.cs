using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public static Menu instance;
    public GameObject go;
    private bool activated;

    public void Exit()
    {
        Application.Quit();
    }
   

    public void Continue()
    {
        activated = false;
        go.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            activated = !activated;
            
            if(activated)
            {
                
                go.SetActive(true);
            }
            else
            {
                go.SetActive(false);
            }
        }
    }
}
