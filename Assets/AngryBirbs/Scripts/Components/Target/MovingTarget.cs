using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    [Range( 0, 5 )]
    public float HalfPathDistance = 3;
    [Range( 0, 5 )]
    public float MovementSpeed = 2;

    public float num = 0;

    private Rigidbody2D body;
    private float startingY;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        startingY = body.position.y;
    }

    private void FixedUpdate()
    {
        num = startingY + Mathf.Sin(Time.time * MovementSpeed) * HalfPathDistance;


        body.MovePosition(new Vector2(body.position.x, num));


    }
}
