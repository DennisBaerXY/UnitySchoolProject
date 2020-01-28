using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menü : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchOptions()
    {

        SceneManager.LoadScene(1);


    }

    public void SwitchBack()
    {

        Application.Quit();


    }


    public void SwitchPlay()
    {

        SceneManager.LoadScene(2);


    }

    public void PlayLevel1()
    {

        SceneManager.LoadScene(2);


    }

    public void PlayLevel2()
    {

        SceneManager.LoadScene(3);


    }

    public void PlayLevel3()
    {

        SceneManager.LoadScene(4);


    }

    public void PlayLevel4()
    {

        SceneManager.LoadScene(5);


    }
}
