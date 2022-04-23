using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    int score;
    TMP_Text scoreText;

    void Start() 
    {
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = "Initiated";
    }

    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
        scoreText.text = score.ToString();
    }

}
