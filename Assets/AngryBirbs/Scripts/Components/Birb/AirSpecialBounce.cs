using UnityEngine;

public class AirSpecialBounce : MonoBehaviour, IAirSpecial
{
    [Range( 0, 1 )]
    public float SlowDownFactor = 1;

    public void ExecuteAirSpecial()
    {
        var rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(Vector2.up * rigidbody.velocity * SlowDownFactor, ForceMode2D.Impulse);

    }
}
