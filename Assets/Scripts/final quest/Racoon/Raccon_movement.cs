using UnityEngine;

public class Raccon_movement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private PlayerInputhanddle inputHandler;

   public Vector2 MoveInput { get; private set; }

    void Awake()
    {
        inputHandler = GetComponent<PlayerInputhanddle>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       MoveInput = inputHandler.MoveInput;
    }
    private void FixedUpdate()
    {
       rb.linearVelocity = MoveInput * speed;
    }


}
