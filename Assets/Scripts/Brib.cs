using UnityEngine;
using UnityEngine.InputSystem;

public class Brib : MonoBehaviour
{
   public PlayerInput playerInput;
    public float FlapPower = 6.0f;
    private InputAction FlapAction;

    public Rigidbody2D rbody;


    private void Start()
    {
        FlapAction = playerInput.actions.FindAction("Flap");
    }

    private void Update()
    {
        if (FlapAction.WasPressedThisFrame())
        {
            rbody.linearVelocityY = FlapPower;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Enemy")
        {
                       Destroy(gameObject);
        }
        if(col.tag == "Goal")
        {
            //Add score
            
        }

    }
}



