using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public TMP_Text TxtScore;
    public TMP_Text TxtHighScore;

    int score = 0;

    void Start()
    {
        score = 0;
    }

    public void Smash()
    {
        score++;
        TxtScore.SetText(score.ToString());
    }

    public void Save()
    {
        PlayerPrefs.SetInt("score", score);
    }

    public void Load()
    {
        int tempScore = PlayerPrefs.GetInt("score");

        TxtHighScore.SetText(tempScore.ToString());
    }
}
