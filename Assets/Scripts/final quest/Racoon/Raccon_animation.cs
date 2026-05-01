using UnityEngine;

public class Raccon_animation : MonoBehaviour
{
    private Animator anim;
    private Raccon_movement movement;
    private Raccon_shoot shoot;

    private Vector2 lastMoveDirection;

    void Awake()
    {
        anim = GetComponent<Animator>();
        movement = GetComponentInParent<Raccon_movement>();
        shoot = GetComponentInParent<Raccon_shoot>();
    }

    private void Start()
    {
       lastMoveDirection = Vector2.right;
    }

    void Update()
    {
        Vector2 move = movement.MoveInput;

        Vector2 aimDirection = shoot.firePoint.right;

        if (move == Vector2.zero)
        {
            lastMoveDirection = aimDirection;
        }
        else 
        {
            lastMoveDirection = move;
        }

        anim.SetFloat("MoveX", lastMoveDirection.x);
        anim.SetFloat("MoveY", lastMoveDirection.y);
        anim.SetFloat("MoveMagnitude", move.magnitude);

        anim.SetFloat("LastMoveX", lastMoveDirection.x);
        anim.SetFloat("LastMoveY", lastMoveDirection.y);
    }

}
