using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreController scoreController;

    void Awake()
    {
        scoreController = FindObjectOfType<ScoreController>();
    }

    public void ShowFinalScore()
    {
        finalScoreText.text = $"Congrat!!!\nYou got a score of {scoreController.CalculateScore()}%";
    }

}
