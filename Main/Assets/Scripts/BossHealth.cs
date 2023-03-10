using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    [SerializeField] private  int HP = 500;
    [SerializeField] private int current_HP;
    [SerializeField] private Text current_hp;
    [SerializeField] private Animator Death;
    [SerializeField] private int Scence;
 



    void Start()
    {
        current_HP = HP;

    }
    public void Damage(int damage)
    {
        current_HP -= damage;
       
        current_hp.text = "Hp: " + current_HP.ToString();
        if (current_HP <= 0)
        {
           Death.SetTrigger("Death");
        }
    }
    public void loadScence()
    {
        SceneManager.LoadScene(Scence);
    }
   [SerializeField] private Transform spiderversepos;
    [SerializeField] private GameObject SpiderVerse;
    public void Pos()
    {
        Instantiate(SpiderVerse, spiderversepos.position, spiderversepos.rotation);


    }
}
    
    

