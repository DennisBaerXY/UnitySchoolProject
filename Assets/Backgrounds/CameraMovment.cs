using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    public GameObject camera;
    float camerax;
   public float cameraspeed;
    // Start is called before the first frame update
    void Start()
    {
        camerax = camera.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        camerax += cameraspeed * Time.deltaTime;
        camera.transform.position = new Vector3(camerax, 0, 0); ;
    }
}
