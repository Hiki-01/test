using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] private float Speed = 100f;
    [SerializeField] private SpriteRenderer Wavesprite;
     private Drake_Movement Player;
    void Start()
    {
        if (Player.sprite == false)
        {
            rb.velocity = transform.right * Speed;
            Wavesprite.flipX = false;
        }
       else if (Player.sprite == true)
        {
            rb.velocity = transform.right * -Speed;
            Wavesprite.flipX = true;

        }



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
            Destroy(gameObject);

        }
    }

}
