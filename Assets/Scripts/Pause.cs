using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

   public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            panel.active = !panel.active;

            if (panel.active)
            {
                Time.timeScale = 0;

            }

            else
            {
                Time.timeScale = 1;
            }

        }

        if (Input.GetKeyDown("h")&&panel.active == true)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }

    }

    public void GoHome()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);

    }
}
