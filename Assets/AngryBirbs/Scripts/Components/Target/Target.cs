using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [Range( 0, 20 )]
    public float MinimumBreakSpeed = 10;

    private void OnCollisionEnter2D( Collision2D collision )
    {
        Debug.Log("Current speed: " + collision.relativeVelocity.magnitude);
        if(collision.relativeVelocity.magnitude >= MinimumBreakSpeed)
        {
            DestroyTarget();
        }
    }

    public void DestroyTarget()
    {
        Destroy( gameObject );
    }
}
