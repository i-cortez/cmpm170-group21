// Coins.cs
//
// Group 21 Programming Team
// 10-24-2020
// This script updates the player score as coins are collected
//
// Adapted from Xlaugts
// https://www.youtube.com/watch?v=DZ-3g31jk90
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
   public int coinValue = 1;

   private void OnTriggerEnter2D(Collider2D other)
   {
      if(other.gameObject.CompareTag("Player 1"))
      {
         ScoreManagerP1.instance.ChangeScore(coinValue);
      }

      if (other.gameObject.CompareTag("Player 2"))
      {
         ScoreManagerP2.instance.ChangeScore(coinValue);
      }
   }
}

