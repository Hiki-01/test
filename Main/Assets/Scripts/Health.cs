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
    private Animator death;
    private Rigidbody2D Death_rb;
    [SerializeField] private AudioSource Deathsound;
    

    void Start()
    {
        current_HP = HP;
        death = gameObject.GetComponent<Animator>();
        Death_rb = GetComponent<Rigidbody2D>();
        

    }
   public void Damage(int damage)
    {
         current_HP-= damage;
        current_hp.text = "Hp: " + current_HP.ToString();


        if (current_HP <= 0)
        {
            Death_rb.bodyType = RigidbodyType2D.Static;
            death.SetTrigger("Death");
            Deathsound.Play();
            current_hp.text = "Hp:You Are Gone to Die Friend ";
        }
       
    }
    public void Rest()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   

}
