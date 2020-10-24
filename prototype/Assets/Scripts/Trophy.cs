// Trophy.cs
//
// Group 21 Programming Team
// 10-24-2020
// This script updates the player score as coins are collected
//


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trophy : MonoBehaviour
{
   public int trophyValue = 30;

   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.gameObject.CompareTag("Player 1"))
      {
         ScoreManagerP1.instance.ChangeScore(trophyValue);
      }

      if (other.gameObject.CompareTag("Player 2"))
      {
         ScoreManagerP2.instance.ChangeScore(trophyValue);
      }
   }
}

