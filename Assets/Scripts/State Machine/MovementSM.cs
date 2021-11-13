using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSM : StateMachine
{
    [HideInInspector] public Idle idleState;
    [HideInInspector] public Moving movingState;
    [HideInInspector] public Jumping jumpingState;

    public Rigidbody2D rigidbody;

    public float speed = 6f;
    public float jumpForce = 7f;

    private void Awake()
    {
        idleState = new Idle(this);
        movingState = new Moving(this);
        jumpingState = new Jumping(this);
    }

    protected override BaseState GetInitialState()
    {
        return idleState;
    }
}
