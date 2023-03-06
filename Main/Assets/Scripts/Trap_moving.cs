using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_Rotate : MonoBehaviour
{
   
    [SerializeField] private float Rotatespeed = 3f;

    private void Update()
    {
        transform.Rotate(0, 0, 360*Rotatespeed*Time.deltaTime);
    }
}
