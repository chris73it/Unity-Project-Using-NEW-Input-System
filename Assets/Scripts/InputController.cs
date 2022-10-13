using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using System;

[Serializable]
public class OnMovementEvent : UnityEvent<Vector2> { }

[Serializable]
public class OnJumpingEvent : UnityEvent<bool> { }

public class InputController : MonoBehaviour
{
    Controls controls;
    
    Vector2 movement;
    bool isJumping;

    public OnMovementEvent onMovementEvent;
    public OnJumpingEvent onJumpingEvent;

    private void Awake()
    {
        controls = new Controls();

        controls.Gameplay.Movement.started += OnMove;
        controls.Gameplay.Movement.canceled += OnMove;
        controls.Gameplay.Movement.performed += OnMove;

        controls.Gameplay.Jumping.started += OnJump;
        controls.Gameplay.Jumping.canceled += OnJump;
        controls.Gameplay.Jumping.performed += OnJump;
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
        onMovementEvent.Invoke(movement);
    }

    private void OnJump(InputAction.CallbackContext context)
    {
        isJumping = context.ReadValueAsButton();
        onJumpingEvent.Invoke(isJumping);
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
