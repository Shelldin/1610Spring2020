//from Brackeys Tutorial

using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform playerTrans;
    public Text textScore;

    private float scoreCorrection;
    
    private void Update()
    {
        //My player starts at a z of -45 and I wanted to figure out how to adjust the score without shifting all the other objs in my game
        var playerTransPosition = playerTrans.position;
        scoreCorrection = playerTransPosition.z += 45f;
        textScore.text = scoreCorrection.ToString("0");
    }
}
