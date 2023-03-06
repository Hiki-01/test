using UnityEngine;
using UnityEngine.UI;
public class Drake_Movement : MonoBehaviour
{
    [SerializeField] private float jump = 14f;
    [SerializeField] private float Movement = 7f;
    public Rigidbody2D rb;
    private Animator anime;
    private float movement;
    public SpriteRenderer sprite; 
    private enum PlayerAnimator { Player_Stop, Player_Running, Player_Jumping, Player_Falling, Sword_Attack }
    private BoxCollider2D collid;
    [SerializeField] private AudioSource jumpsound;
    private PlayerAnimator State;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        collid = GetComponent<BoxCollider2D>();
      
    }
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movement * Movement, rb.velocity.y);


        if (Input.GetButtonDown("Jump") && Isfalls())
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
            jumpsound.Play();
        }
        Animator();


    }
    private void Animator()
    {
        if (movement > 0f)
        {
            State = PlayerAnimator.Player_Running;
            sprite.flipX=false;
            
        }
        else if (movement < 0f)
        {
            State = PlayerAnimator.Player_Running;
            sprite.flipX = true;
            
        }
        else
        {
            State = PlayerAnimator.Player_Stop;

        }
        if (rb.velocity.y > .1f)
        {
            State = PlayerAnimator.Player_Jumping;
        }
        else if (rb.velocity.y < -.1f)
        {
            State = PlayerAnimator.Player_Falling;
        }
        if (Input.GetKeyDown("z"))
        {
            State = PlayerAnimator.Sword_Attack;
        }

        anime.SetInteger("State", (int)State);

    }
    [SerializeField] private LayerMask JumpingLayer;
    private bool Isfalls()
    {
        return Physics2D.BoxCast(collid.bounds.center, collid.bounds.size, 0f, Vector2.down, .1f, JumpingLayer);
    }
    [SerializeField] private GameObject Wave;
    [SerializeField] private Transform wavepos;
    public void Drakeattak()
    {
            Instantiate(Wave, wavepos.position, wavepos.rotation);
    }
   
}
