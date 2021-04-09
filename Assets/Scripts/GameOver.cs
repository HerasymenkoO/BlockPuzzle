using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver;

    private void OnEnable()
    {
        GameEvents.GameOver += OnGameOver;
    }
    private void OnDisable()
    {
        GameEvents.GameOver -= OnGameOver;
    }
    void Start()
    {
        gameOver.SetActive(false);
    }

    private void OnGameOver(bool newBestScore)
    {
        gameOver.SetActive(true);
    }
}
