using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour {

    public Text ScoreText;

    public void Awake()
    {
        EventAggregator.ScoreIncrement.Subscribe(OnScoreChange);
    }

    private void OnScoreChange(ScoresManager scoresManager)
    {
        ScoreText.text = calculateScores(ScoreText, scoresManager);
    }

    private string calculateScores(Text ScoreText, ScoresManager scoresManager)
    {
        ScoreText.text = Convert.ToString( scoresManager.Scores);
        return ScoreText.text;
    }
}
