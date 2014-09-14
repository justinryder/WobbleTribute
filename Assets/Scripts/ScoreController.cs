using System;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
  public DartBoard DartBoard;

  public int Points { get; private set; }

  public int Deaths { get; private set; }

  public void Start()
  {
    if (DartBoard)
    {
      DartBoard.PlayerHit += HitDartBoard;
    }
  }

  public void OnDestroy()
  {
    if (DartBoard)
    {
      DartBoard.PlayerHit -= HitDartBoard;
    }
  }

  private void HitDartBoard(object o, EventArgs e)
  {
    AddPoints(1);
  }

  public void AddPoints(int points)
  {
    Points += points;
  }

  public void AddDeath()
  {
    Deaths++;
  }
}