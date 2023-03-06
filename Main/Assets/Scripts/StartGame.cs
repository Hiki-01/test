using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public void ChangeScene(int scene2D)
    {
        SceneManager.LoadScene(scene2D);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
