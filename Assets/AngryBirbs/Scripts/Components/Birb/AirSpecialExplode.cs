using UnityEngine;

public class AirSpecialExplode : MonoBehaviour, IAirSpecial
{
    [Range( 0, 5 )]
    public float BlastRadius = 2;

    public void ExecuteAirSpecial()
    {
        Vector2 origin = transform.position;

        RaycastHit2D[] hits = Physics2D.CircleCastAll(origin, BlastRadius, Vector2.zero);

        

        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit2D hit = hits[i];

            if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Target"))
            {
                hit.transform.GetComponent<Target>().DestroyTarget();
            }
        }
        
    }
}
