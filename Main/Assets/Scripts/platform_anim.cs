using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_anim : MonoBehaviour
{   [SerializeField] private GameObject[] roadway;
    private int roadwayindex=0;
    [SerializeField] private float speed = 3f;

    private void Update()
    {
        if (Vector2.Distance(roadway[roadwayindex].transform.position, transform.position)<0.1f) 
        {
            if(gameObject.CompareTag("Not Boss"))
            {
                if (roadway[roadwayindex]=roadway[0])
                {
                    transform.rotation = Quaternion.Euler(0, 180, 0);
                }
                else if (roadway[roadwayindex] = roadway[1])
                {
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
              
            roadwayindex++;
            if (roadwayindex >= roadway.Length) 
            {
                roadwayindex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, roadway[roadwayindex].transform.position, Time.deltaTime * speed);
    }
}
