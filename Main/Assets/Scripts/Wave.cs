using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] private float Speed = 100f;
    [SerializeField] private float Timer = 1f;
    void Start()
    {   
            rb.velocity = transform.right *Speed;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        BossHealth Damage = collision.GetComponent<BossHealth>();
        if (Damage != null) {
            Damage.Damage(20);
            if (collision.gameObject.CompareTag("Spider"))
            {
                Destroy(gameObject);
            }
            Destroy(gameObject,Timer);

        }
    }

}
