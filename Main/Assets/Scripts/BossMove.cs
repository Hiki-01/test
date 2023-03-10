using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    Transform Player;
    Rigidbody2D rb;
    [SerializeField] float speed = 3f;
    [SerializeField] float swordrange = 1f;
    [SerializeField] float spiderrange = 5f;

    private Animator Bossanime;
    private enum PlayerAnimator { Boss_run, Boss_Sword, Boss_Spider }
    private PlayerAnimator Boss;
    // Start is called before the first frame update
    void Start()
    {
        Bossanime = gameObject.GetComponent<Animator>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(Player.position, rb.position) <= swordrange)
        {
            Boss = PlayerAnimator.Boss_Sword;
        }
        else if (Vector2.Distance(Player.position, rb.position) <= spiderrange)
        {
            Boss = PlayerAnimator.Boss_Spider;

        }
        else
        {
            Boss = PlayerAnimator.Boss_run;
        }
        Bossanime.SetInteger("Boss", (int)Boss);
    }
}
