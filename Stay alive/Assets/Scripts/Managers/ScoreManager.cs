using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// Developer:  Perry Ellis
/// Program:    Stay alive
/// Purpose:    Kill or be killed
/// Date:       4/17/2018
/// </summary>
public class ScoreManager : MonoBehaviour
{
    public static int score;        
    Text text;                      


    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();

        // Reset the score.
        score = 0;
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Score: " + score;
    }
}