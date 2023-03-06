using UnityEngine.SceneManagement;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public void ChangeScene(int scene2D)
    {
        SceneManager.LoadScene(scene2D);
    }
}

