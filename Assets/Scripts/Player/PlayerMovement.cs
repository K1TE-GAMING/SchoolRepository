using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private PlayerInputhanddle inputHandler;

    //Animator anim;
    //private Vector2 lastMoveDirection;
    //private bool facingDown = true;

    void Awake()
    {
        inputHandler = GetComponent<PlayerInputhanddle>();
    }

    void Start()
    {
        //anim = GetComponent<Animator>();

    }

    void Update()
    {

        Vector2 direction = inputHandler.MoveInput;
        ProccessInputs();
        //Animate();

    }

    private void FixedUpdate()
    {
        Vector2 direction = inputHandler.MoveInput;

        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = direction * speed;


    }

    void ProccessInputs()
    {
        float moveX = inputHandler.MoveInput.x;
        float moveY = inputHandler.MoveInput.y;

        //if((moveX == 0 && moveY == 0) && (inputHandler.MoveInput.x != 0 || inputHandler.MoveInput.y != 0))
        //{
        //    lastMoveDirection = inputHandler.MoveInput;
        //}
    }

    //void Animate()
    //{
    //    anim.SetFloat("MoveX", inputHandler.MoveInput.x);
    //    anim.SetFloat("MoveY", inputHandler.MoveInput.y);
    //    anim.SetFloat("MoveMagnitude", inputHandler.MoveInput.magnitude);
    //    anim.SetFloat("LastMoveX", lastMoveDirection.x);
    //    anim.SetFloat("LastMoveY", lastMoveDirection.y);
    //}
}
