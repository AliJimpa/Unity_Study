using UnityEngine;
using UnityEngine.InputSystem;

public class InputWithAsset : MonoBehaviour
{
    [SerializeField]
    private InputActionAsset inputActionsAsset;

    private InputAction moveAction;
    private InputAction jumpAction;
    private InputAction lookAction;

    private void Awake()
    {
        // Get the "Player" action map
        InputActionMap  playerMap = inputActionsAsset.FindActionMap("Player");

        // Get individual actions
        //moveAction = playerMap.FindAction("Move");
        jumpAction = playerMap.FindAction("Jump");
        //lookAction = playerMap.FindAction("Look");

        // Register callbacks
        jumpAction.performed += OnJump;
    }

    private void OnEnable()
    {
        //moveAction.Enable();
        jumpAction.Enable();
        //lookAction.Enable();
    }

    private void OnDisable()
    {
        //moveAction.Disable();
        jumpAction.Disable();
        //lookAction.Disable();
    }

    // private void Update()
    // {
    //     Vector2 move = moveAction.ReadValue<Vector2>();
    //     Vector2 look = lookAction.ReadValue<Vector2>();

    //     // Example usage
    //     Debug.Log($"Move: {move}, Look: {look}");
    // }

    private void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump performed!");
    }

}
