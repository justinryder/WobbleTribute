using UnityEngine;

public class ScoreController : MonoBehaviour
{
  private int _points;

  private int _deaths;

  public void AddPoints(int points)
  {
    _points += points;
  }

  public void AddDeath()
  {
    _deaths++;
  }

  public void OnGUI()
  {
    GUILayout.TextArea("Points: " + _points);
    GUILayout.TextArea("Deaths: " + _deaths);
  }
}