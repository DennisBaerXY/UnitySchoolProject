using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldSelectionMenu : MonoBehaviour
{
    public Text TextWelt;

    public GameObject Welt1, Welt2;
    public int World;
    public int maxWelten;
    // Start is called before the first frame update
    void Start()
    {
        World = 1;
    }

    // Update is called once per frame
    void Update()
    {

        switch (World)
        {
            case 1:


                Welt1.SetActive(true);
                Welt2.SetActive(false);
                break;
            case 2:
                Welt1.SetActive(false);
                Welt2.SetActive(true);
                break;

        }
        TextWelt.text = "Welt " + World;
    }



    public void NextWorld()
    {
        if (World < maxWelten)
        {
            World++;
        }

        else
        {
            World = 1;
        }

    }


    public void PreviouseWorld()
    {
        if (World > 1)
        {
            World--;

        }
        else
        {
            World = maxWelten;
        }

    }
}

