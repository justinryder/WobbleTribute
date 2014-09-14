using UnityEngine;

public class ScoreController : MonoBehaviour
{
  public int Points { get; private set; }

  public int Deaths { get; private set; }

  public void AddPoints(int points)
  {
    Points += points;
  }

  public void AddDeath()
  {
    Deaths++;
  }
}