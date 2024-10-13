using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{


    public GameObject scoreBoard;

    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI highScoreText;

    public Image medal;

    public Sprite[] medals;

    public void ShowScoreBoard(int score)
    {
        scoreBoard.SetActive(true);
        scoreText.text = score.ToString("D4");

        var hightScore = PlayerPrefs.GetInt("HighScore", 0);
        if (score > hightScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
            PlayerPrefs.Save();
            highScoreText.text = score.ToString("D4");
            medal.sprite = medals[0];
        }
        else
        {
            highScoreText.text = hightScore.ToString("D4");
            medal.sprite = medals[1];
        }
    }
}

