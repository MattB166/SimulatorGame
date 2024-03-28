using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


enum PlayerState
{
    ///possible states 
}
/// <summary>
/// Manages the movement of the character 
/// </summary>
[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    [Header("Movement Components")]
    [Range(1, 10)] public float walkSpeed = 5;
    [Range(1, 10)] public float runSpeed = 10;
    [Range(1, 10)] public float stealthSpeed = 2;
    [Range(1, 10)] public float stamina = 15;
    [HideInInspector] public Vector2 input;
    private float maxStamina;

    [Header("Jumping Components")]
    private bool isJumping;
    [Range(-20f, -0.05f)] public float gravity;
    [Range(0.1f, 0.5f)] public float groundCheckDistance;
    public LayerMask groundLayer;

    private void Start()
    {
       controller = GetComponent<CharacterController>();
        
        InitialisePlayer();
    }

    private void Update()
    {
        Vector3 move = Move();

        controller.Move(new Vector3(move.x, 0, move.z) * Time.deltaTime);  //need to alter y value to represent y velocity 
    }

    /// <summary>
    /// Initialises the player to starting values
    /// </summary>
    private void InitialisePlayer()
    { 
        ////initialise starting values here 
    }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        input = context.ReadValue<Vector2>();
        Debug.Log("Reading input");
    }

    public void OnJumpInput(InputAction.CallbackContext context)
    {
        
        if(context.performed)
        {
           
           
        }
        
    }

    private Vector3 Move()
    {
        Vector3 movement = transform.right * input.x + transform.forward * input.y;
        movement.Normalize();
        movement*= walkSpeed;
        return movement;


    }
}
