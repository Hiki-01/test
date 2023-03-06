using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword_Trap : MonoBehaviour
{
     private Rigidbody2D rb;
    [SerializeField] private GameObject Sword;
    private void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Sword.SetActive(true);
        }  
    }
}
