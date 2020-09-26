﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScore_Setter : MonoBehaviour
{
    public Text HighScore_txt;
    public Text CurrentScore_txt;

    public int high_score;
    public int new_score;

    void Start()
    {
        HighScore_txt.text = PlayerPrefs.GetInt("highscore_lvl1", 0).ToString();
        high_score = PlayerPrefs.GetInt("highscore_lvl1", 0);
    }

    void Update()
    {
        new_score = int.Parse(CurrentScore_txt.text);
        if (new_score > high_score)
        {
            PlayerPrefs.SetInt("highscore_lvl1", new_score);
            HighScore_txt.text = new_score.ToString();
        }
    }
}
