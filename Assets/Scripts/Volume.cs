using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public Slider slider;
    public Text VolumeText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VolumeText.text = "Volume: " + System.Math.Round(slider.value);
    }
    

    public void OnValueChange()
    {



    }
}
