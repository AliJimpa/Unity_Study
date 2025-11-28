using UnityEngine;
using UnityEngine.InputSystem;

public class InputWithCode : MonoBehaviour
{
    public MustardInput inputActions;

    private void Awake()
    {
        inputActions = new MustardInput();
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
        //inputActions.Player.Move.performed += OnMove;
        inputActions.Player.Jump.performed += OnJump;
    }

    private void OnDisable()
    {
        inputActions.Player.Disable();
        //inputActions.Player.Move.performed -= OnMove;
        inputActions.Player.Jump.performed -= OnJump;
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();
        Debug.Log("Move: " + direction);
    }

    private void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump");
    }
}
