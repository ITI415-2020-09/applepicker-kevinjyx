using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class HighScores : MonoBehaviour
{
    // Start is called before the first frame update
    static public int score = 1000;
    void Start()
    {
        
    }
    void Awake()
    {
        if (PlayerPrefs.HasKey("ApplePickerHighScore"))
        {
            score = PlayerPrefs.GetInt("ApplePickerHighScore");
        }
        PlayerPrefs.SetInt("ApplePickerHighScore", score);
    }

    // Update is called once per frame
    void Update()
    {
        TextMesh scoreGT = this.GetComponent<TextMesh>();
        scoreGT.text = "High Score: " + score;
    }
}
