using UnityEngine;
using UnityEngine.InputSystem;

public class InputWithAction : MonoBehaviour
{
    public InputActionReference JumpAction;
    private void OnEnable()
    {
        JumpAction.action.performed += OnJump;
    }
    private void OnDisable()
    {
        JumpAction.action.performed -= OnJump;
    }

    private void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump performed!");
    }

}