
using UnityEngine;

public class Player_Camera : MonoBehaviour
{
    [SerializeField] private Transform Player;
    void Update()
    {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, transform.position.z);
    }
}
