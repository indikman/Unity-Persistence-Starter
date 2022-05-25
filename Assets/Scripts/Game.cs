using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public TMP_Text TxtScore;

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
}
