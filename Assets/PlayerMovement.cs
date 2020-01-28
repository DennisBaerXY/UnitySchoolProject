using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    float horizontalMove = 0f;
    public float speed = 40f;
    public Animator animator;
    bool jump;

    public CharacterController2D controller;
    void Start()
    {
        
    }
    private void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if(Input.GetButtonDown("Jump"))
        {

            jump = true;
            animator.SetBool("Jumping", true);

        }
    }
    public void OnLanding()
    {

        animator.SetBool("Jumping", false);

    }
   



    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime,false,jump);
        jump = false;
    }

  


}
