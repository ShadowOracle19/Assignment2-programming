using UnityEngine;

public class AirSpecialSplit : MonoBehaviour, IAirSpecial
{
    public float SplitAngleInDegrees = 10;

    public void ExecuteAirSpecial()
    {
        var rigidBodyOriginal = GetComponent<Rigidbody2D>();


        Vector2 direction = gameObject.transform.position * Vector2.up;

        var birbCopy1 = Birb.MakeBirbCopy(this.gameObject);
        var rigidBody1 = birbCopy1.GetComponent<Rigidbody2D>();
        rigidBody1.simulated = true;
        rigidBody1.AddForce(rigidBodyOriginal.velocity , ForceMode2D.Impulse);
        rigidBody1.velocity = rigidBodyOriginal.velocity;
        rigidBody1.AddForce(Vector2.up * SplitAngleInDegrees, ForceMode2D.Impulse);



        var birbCopy2 = Birb.MakeBirbCopy(this.gameObject);
        var rigidBody2 = birbCopy2.GetComponent<Rigidbody2D>();
        rigidBody2.simulated = true;
        rigidBody2.AddForce(rigidBodyOriginal.velocity * direction, ForceMode2D.Impulse);
        rigidBody2.velocity = rigidBodyOriginal.velocity;
        rigidBody2.AddForce(Vector2.down * SplitAngleInDegrees, ForceMode2D.Impulse);


    }
}
