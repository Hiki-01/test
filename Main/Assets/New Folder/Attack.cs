using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private float swordrange = 1f;
    [SerializeField] Vector3 swordoff;
    [SerializeField] private LayerMask SwordMask;

    public void Sword()
    {
        Vector3 posinion = transform.position;
        posinion += transform.right*swordoff.x;
        posinion += transform.up * swordoff.y;

        Collider2D collider = Physics2D.OverlapCircle(posinion, swordrange, SwordMask);
        if(collider!=null)
        {
            collider.GetComponent<Health>().Damage(25,1);
        }

    }

}
