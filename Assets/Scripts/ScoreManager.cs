using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;


    private int score = 0;

    private void Start()
    {
        FindObjectOfType<GameManager>().AddEventToGameEnd(EndGame);
    }

    public void UpdateScore()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }

    private void EndGame()
    {
        FindObjectOfType<EndGameUI>().ShowScores(score);
    }
}