using UnityEngine.UI;
using UnityEngine;

public class SpiderAttack : MonoBehaviour
{
     public Rigidbody2D rb;
    [SerializeField] private float Speed = 100f;
    [SerializeField] private int stillhold;
    [SerializeField] private float destroy = 10;
     void Start()
    {
        rb.velocity = transform.right * -Speed;
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        Health Damage = collision.GetComponent<Health>();
        if (Damage != null )
        {
            
            Damage.Damage(50, 0);
            if (collision.gameObject.CompareTag("Wave"))
            {
                Destroy(gameObject);
            }
        
            
        }
        Destroy(gameObject,destroy);
    }
    

}
