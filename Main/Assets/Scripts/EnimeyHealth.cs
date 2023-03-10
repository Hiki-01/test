using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EnimeyHealth : MonoBehaviour
{
    [SerializeField] private  int HP = 50;
    [SerializeField] private int current_HP;
    [SerializeField] private Animator Death;
 
    void Start()
    {
        current_HP = HP;

    }
    public void Damage(int damage)
    {
        current_HP -= damage;
       
       
        if (current_HP <= 0)
        {
           Death.SetTrigger("Death");
        }
    }
    public void destroy()
    {
        Destroy(gameObject);
    }
}
    
    

