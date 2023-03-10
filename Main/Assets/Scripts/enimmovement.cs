using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enimmovement : StateMachineBehaviour
{
    Transform Player;
    Transform Point1;
    Transform Point2;
    Rigidbody2D rb;
    [SerializeField] float swordrange = 1f;
    [SerializeField] float speed = 3f;
    filped IsFilped;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        Point1 = GameObject.FindGameObjectWithTag("Point1").transform;
        Point2 = GameObject.FindGameObjectWithTag("Point2").transform;
        rb = animator.GetComponent<Rigidbody2D>();
        IsFilped = animator.GetComponent<filped>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
   override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        IsFilped.enimefilped();
        Vector2 player_pos = new Vector2(Point1.position.x, rb.position.y);
        Vector2 target = Vector2.MoveTowards(rb.position, player_pos, speed * Time.fixedDeltaTime);
        rb.MovePosition(target);

        if (Vector2.Distance(Point1.position, rb.position) < 0.1f)
        {  
             target = Vector2.MoveTowards(rb.position, player_pos, -speed * Time.fixedDeltaTime);
        }
        else if (Vector2.Distance(Point2.position, rb.position) < 0.1f)
        {
             target = Vector2.MoveTowards(rb.position, player_pos, speed * Time.fixedDeltaTime);
        }

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
