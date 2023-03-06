using UnityEngine.UI;
using UnityEngine;

public class Points : MonoBehaviour
{
    private int point1 = 0;
    private int point2 = 0;
    private int score = 0;
    private int highscore = 0;
    [SerializeField] public Text HighScore;
    [SerializeField] public Text Score;
    [SerializeField] private AudioSource Point1Sound;
    [SerializeField] private AudioSource Point2Sound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Point 1"))
        {
            point1++;
            Destroy(collision.gameObject);
            Point1Sound.Play();
        }
        else if (collision.gameObject.CompareTag("Point 2"))
        {
            point2+=2;
            Destroy(collision.gameObject);
            Point2Sound.Play();
        }
        score = point1 + point2;
        Score.text = "Score: "+score.ToString();
        if (score > highscore)
        {
            highscore = score;
            HighScore.text ="High Score: "+highscore.ToString();
        }
    }

}
