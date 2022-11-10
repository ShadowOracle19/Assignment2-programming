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

    private void FixedUpdate()
    {
        num = Mathf.Lerp(-HalfPathDistance, HalfPathDistance, Mathf.PingPong(Time.time, MovementSpeed));

    }
}
