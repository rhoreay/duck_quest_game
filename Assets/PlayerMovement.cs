using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float MoveSpeed = 5f;
    public Rigidbody2D rb;
    private Vector2 MoveInput;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = MoveInput * MoveSpeed;
    }

    public void Move(InputAction.CallbackContext context){

        MoveInput = context.ReadValue<Vector2>();

    }

}
