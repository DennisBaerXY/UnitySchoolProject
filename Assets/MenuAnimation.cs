using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimation : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {

        animator.Play("Open");
    }

    public void Close()
    {
        animator.Play("Close");
    }


    public void OptionsOpen()
    {

        animator.Play("Options_Open");
    }

    public void OptionsClose()
    {
        animator.Play("Options_Close");
    }
}
