using UnityEngine;
using TMPro;

public class EndGameUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI highScoreText;

    public void ShowScores(int score)
    {
        scoreText.text = "Score: " + score;
        if (PlayerPrefs.HasKey("highScore"))
        {
            int highScore = PlayerPrefs.GetInt("highScore");
            if(score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetInt("highScore", score);
            }

            highScoreText.text = "High Score: " + highScore;
        }
        else
        {
            highScoreText.text = "High Score: " + score;
            PlayerPrefs.SetInt("highScore", score);
        }
    }
}
