// ScoreManager1.cs
//
// Group 21 Programming Team
// 10-24-2020
// This script updates the player 1 score as coins are collected
//
// Adapted from Xlaugts
// https://www.youtube.com/watch?v=DZ-3g31jk90
//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManagerP1 : MonoBehaviour
{

   public static ScoreManagerP1 instance;
   public TextMeshProUGUI text;
   int score;
   
   // Start is called before the first frame update
   void Start()
   {
      if (instance == null) instance = this;
   }
   
   // Update is called once per frame
   void Update()
   {
   }

   public void ChangeScore(int coinValue)
   {
      score += coinValue;
      text.text = "x" + score.ToString();
   }
}

