using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : StateMachineBehaviour
{
    Transform Player;
    Rigidbody2D rb;
    [SerializeField] float speed = 3f;
    filped IsFilped;
    
   
    


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
      
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        rb=animator.GetComponent<Rigidbody2D>();
        IsFilped=animator.GetComponent<filped>();
       

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
   override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
        IsFilped.enimefilped();
        Vector2 player_pos = new Vector2(Player.position.x, rb.position.y);
       Vector2 target= Vector2.MoveTowards(rb.position, player_pos, speed * Time.fixedDeltaTime);
        rb.MovePosition(target);

       

 }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
    

}
