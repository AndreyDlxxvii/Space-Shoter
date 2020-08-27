using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text ScoreText;
    public Text GameOverText;
    public Text PlayerLive;

    private int _playerScore = 0;
    private int _playerLive = 100;

    public void AddScore()
    {
        _playerScore++;
        ScoreText.text = _playerScore.ToString();
    }

    public void PlayeSubtrackLive() 
    {
        _playerLive -= 20;
        PlayerLive.text = _playerLive.ToString();
        if (_playerLive == 0)
        {
            GameOverText.enabled = true;
            Time.timeScale = 0;
        }

    }
}
