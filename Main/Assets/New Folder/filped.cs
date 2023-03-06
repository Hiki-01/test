using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class filped : MonoBehaviour
{
    bool Filp = false;
    [SerializeField] private Transform Player;
   public void enimefilped()
    {
        Vector3 filpenime = transform.localScale;
        filpenime.z*= -1f;
        if (transform.position.x > Player.position.x &&Filp)
        {
            transform.localScale = filpenime;
            transform.Rotate(0f, 180f, 0f);
            Filp = false;
        }
       else if (transform.position.x < Player.position.x && !Filp)
        {
            transform.localScale = filpenime;
            transform.Rotate(0f,180f, 0f);
            Filp = true;
        }
    }
}
