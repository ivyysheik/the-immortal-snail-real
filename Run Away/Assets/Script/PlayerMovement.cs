using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
[RequireComponent (typeof (CharacterController))]
public class PlayerMovement : MonoBehaviour
{   

    private Quaternion targetRotation; 

    public float rotationSpeed = 450; 
    public float walkSpeed = 5;
    public float runSpeed = 8;
    Animator myAnimator;
    public Vector3 velocity; 
   

   private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));

        transform.rotation = Quaternion.LookRotation(input);

        if (input != Vector3.zero)
        {
            targetRotation = transform.rotation = Quaternion.LookRotation(input);
            transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y,targetRotation.eulerAngles.y, rotationSpeed * Time.deltaTime);
            velocity = input.normalized * walkSpeed; 


           
            
        }

        else
        {
            velocity = new Vector3(0, velocity.y, 0);
        }

        if (input.magnitude > 0)
        {
            myAnimator.SetBool("Walking", true);
        }
        else
        {
            myAnimator.SetBool("Walking", false);
        }




        /*if (Input.GetKeyDown(KeyCode.A))
        {
            myAnimator.SetBool("Walking", true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            myAnimator.SetBool("Walking", false);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            myAnimator.SetBool("Walking", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            myAnimator.SetBool("Walking", false);
        }

          if (Input.GetKeyDown(KeyCode.S))
        {
            myAnimator.SetBool("Walking", true);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            myAnimator.SetBool("Walking", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            myAnimator.SetBool("Walking", true);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            myAnimator.SetBool("Walking", false);
        }
        */

  


        Vector3 motion = input;
        motion += Vector3.up * -8;
        controller.Move(input * Time.deltaTime);
        
    }
}
