using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public Text scoreText;
    private int _currentScore;

    private void OnEnable()
    {
        GameEvents.AddScores += AddScores;

    }

    private void OnDisable()
    {
        GameEvents.AddScores -= AddScores;
    }
    void Start()
    {
        _currentScore = 0;
        UpdateScoreText();
    }
    private void AddScores(int scores)
    {
        _currentScore += scores;
        UpdateScoreText();
    }
    private void UpdateScoreText()
    {
        scoreText.text = _currentScore.ToString();
    }
}
