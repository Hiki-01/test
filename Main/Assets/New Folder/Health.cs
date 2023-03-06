using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private const int HP = 200;
    [SerializeField] private int current_HP;
    [SerializeField] private Text current_hp;
     private int Lifes=3;
    private int currentLifes;
    [SerializeField] private Text current_Lifes;
    [SerializeField] private int Scence;
    BoxCollider2D collider2D;
    private Animator death;



    void Start()
    {
        current_HP = HP;
        death = gameObject.GetComponent<Animator>();
    }
   public void Damage(int damage,int takelife)
    {
         current_HP-= damage;
        if (collider2D.gameObject.CompareTag("Trap"))
        {
            current_HP -= 20;
        }
        current_hp.text = "Hp: " + current_HP.ToString();


        if (current_HP <= 0)
        {
            Rest();
            

            if (currentLifes <= 0)
            {
                death.SetTrigger("Death");   
            }
        }
       
    }
    
    public void loadScence()
    {
        SceneManager.LoadScene(Scence);
    }
    public void Rest()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        currentLifes -=1;
        current_Lifes.text = "Lifes: " + currentLifes.ToString();
    }

}
