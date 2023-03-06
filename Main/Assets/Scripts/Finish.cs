using UnityEngine.SceneManagement;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private Animator FinishPoint;
    [SerializeField]private AudioSource finishpoint;
    [SerializeField] private GameObject nextPlat;
    [SerializeField] private float time=10f;
    private bool IsLevelComplete = false;

    void Start()
    {
        FinishPoint = GetComponent<Animator>();
        finishpoint = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && IsLevelComplete==false)
        {
            finishpoint.Play();
            FinishPoint.enabled=true;
            IsLevelComplete = true;
            nextPlat.SetActive(true);
            Invoke("next", time);
        }
    }
    private void next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
