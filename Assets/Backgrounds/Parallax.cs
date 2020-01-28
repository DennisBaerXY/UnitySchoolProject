using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
   
    public float speed;
    public float endX;
    public float startX;
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <= endX)
        {
            Vector3 pos = new Vector3(startX, transform.position.y,10);
            transform.position = pos;
        }
    }
}
       


