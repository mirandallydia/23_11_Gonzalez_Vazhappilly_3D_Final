using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCPlayerMovement : MonoBehaviour
{

    private CharacterController characterController;
    public float speed = 10f;
    public float jumpheight = 20f;
    private Vector3 velocity;

    public float gravityMultiplier = 10f;


    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveZ = transform.forward * Input.GetAxis("Vertical");
        Vector3 moveX = transform.right * Input.GetAxis("Horizontal");
       
        Vector3 move = (moveZ + moveX) * speed;

        velocity.y += Physics.gravity.y * gravityMultiplier * Time.deltaTime;
        move.y = velocity.y;

        characterController.Move(move * Time.deltaTime);
        if(characterController.isGrounded) 
        {
            velocity.y = 0;
        }
        if(Input.GetButtonDown("Jump") && characterController.isGrounded)
        {
            velocity.y += jumpheight;

        
        }
    }
}
