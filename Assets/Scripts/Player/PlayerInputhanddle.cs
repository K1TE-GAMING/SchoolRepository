using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputhanddle : MonoBehaviour
{
    public PlayerInput playerInput;
    private InputAction moveAction;

    public Vector2 MoveInput { get; private set; }

    void Awake()
    {

        moveAction = playerInput.actions.FindAction("Move");

    }

    void Update()
    {

        MoveInput = moveAction.ReadValue<Vector2>();

    }
}
