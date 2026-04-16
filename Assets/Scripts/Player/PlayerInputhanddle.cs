using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputhanddle : MonoBehaviour
{
    public PlayerInput playerInput;
    private InputAction moveAction;
    private InputAction shootAction;
    private InputAction aimAction;

    public Vector2 MoveInput { get; private set; }
    
    public bool ShootPressed { get; private set; }

    public Vector2 AimInput { get; private set; }

    void Awake()
    {

        moveAction = playerInput.actions.FindAction("Move");
        shootAction = playerInput.actions.FindAction("Shoot");
        aimAction = playerInput.actions.FindAction("Aim");

    }

    void Update()
    {

        MoveInput = moveAction.ReadValue<Vector2>();
        ShootPressed = shootAction.triggered;
        AimInput = aimAction.ReadValue<Vector2>();
    }
}
