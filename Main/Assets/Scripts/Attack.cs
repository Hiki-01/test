using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private float swordrange = 1f;
    [SerializeField] Vector3 swordoff;
    [SerializeField] private LayerMask SwordMask;
     private Collider2D collider;

    void Start()
    {
        collider = gameObject.GetComponent<BoxCollider2D>();
    }
    public void Sword()
    {
        Vector3 posinion = transform.position;
        posinion += transform.right*swordoff.x;
        posinion += transform.up * swordoff.y;

         collider = Physics2D.OverlapCircle(posinion, swordrange, SwordMask);
        if(collider!=null)
        {
            collider.GetComponent<Health>().Damage(25);
        }

    }

}
