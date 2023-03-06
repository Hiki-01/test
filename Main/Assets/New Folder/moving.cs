using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : StateMachineBehaviour
{
    Transform Player;
    Rigidbody2D rb;
    [SerializeField] float speed = 3f;
    filped IsFilped;
    [SerializeField] float swordrange = 1f;
    [SerializeField] float spiderrange=7f;
    [SerializeField] private Transform Boss;
    
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       Player = GameObject.FindGameObjectWithTag("Player").transform;
        rb=animator.GetComponent<Rigidbody2D>();
        IsFilped=animator.GetComponent<filped>();
        Boss = GameObject.FindObjectOfType<Transform>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
   override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       IsFilped.enimefilped();
        Vector2 player_pos = new Vector2(Player.position.x, rb.position.y);
       Vector2 target= Vector2.MoveTowards(rb.position, player_pos, speed * Time.fixedDeltaTime);
        rb.MovePosition(target);
        if (Vector2.Distance(Player.position, rb.position)<=swordrange)
        {
            animator.SetTrigger("Sword");
        }
        if (Vector2.Distance(Player.position,Boss.position) == swordrange)
        {
            animator.SetTrigger("Spider");
        }
        /*timer+=Time.deltaTime;
         if(timer>timereload)
         {
             timer = 0;
             animator.SetTrigger("Spider");
         }*/
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Sword");
        animator.ResetTrigger("Spider");
    }
    private float timer;
    [SerializeField] private float timereload=2f;


}
