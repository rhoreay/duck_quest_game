using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float MoveSpeed = 5f;
    public Rigidbody2D rb;
    private Vector2 MoveInput;
    private Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = MoveInput * MoveSpeed;
    }

    public void Move(InputAction.CallbackContext context){
        animator.SetBool("IsWalking", true);

        if(context.canceled){
            animator.SetBool("IsWalking", false);
            animator.SetFloat("LastInputX", MoveInput.x);
            animator.SetFloat("LastInputY", MoveInput.y);
        }

        MoveInput = context.ReadValue<Vector2>();
        animator.SetFloat("InputX", MoveInput.x);
        animator.SetFloat("InputY", MoveInput.y);
    }

}
