using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enimmovement : StateMachineBehaviour
{
    Transform Player;
    Rigidbody2D rb;
    [SerializeField] float swordrange = 1f;
 
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        rb =animator.GetComponent<Rigidbody2D>();
       
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
   override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    
        if (Vector2.Distance(Player.position, rb.position) <= swordrange)
        {
            animator.SetTrigger("Attack");
        }

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Attack");
        
    }
}
