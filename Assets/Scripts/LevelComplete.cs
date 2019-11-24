﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelComplete : MonoBehaviour
{
    public Text txHighScore;
    int highscore;

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("HS", 0);

        if (Coins.score > highscore)
           {
	            highscore = Coins.score;
	            PlayerPrefs.SetInt("HS", highscore);
	        }

        txHighScore.text = highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Replay()
    {
        Coins.score = 0;
        SceneManager.LoadScene(Coins.scene);
    }

    public void Next()
    {
        Coins.score = 0;
        SceneManager.LoadScene(Coins.scene+1);
    }
}
