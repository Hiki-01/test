using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Back : MonoBehaviour
{
    public void ChangeScene(int scene2D)
    {
        SceneManager.LoadScene(scene2D);
    }
}
