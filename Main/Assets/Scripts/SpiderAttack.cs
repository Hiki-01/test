using UnityEngine.UI;
using UnityEngine;

public class SpiderAttack : MonoBehaviour
{
     public Rigidbody2D rb;
    [SerializeField] private float Speed = 100f;
    [SerializeField] private float destroy = 2;
     void Start()
    {
        rb.velocity = transform.right * -Speed;
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        Health Damage = collision.GetComponent<Health>();
        if (Damage != null)
        {

            Damage.Damage(10);
            if (collision.gameObject.CompareTag("Wave"))
            {
                Destroy(gameObject);
            }
            Destroy(gameObject);
        }
        else if (Damage = null)
        {
            Destroy(gameObject, destroy);
        }
    }
    

}
