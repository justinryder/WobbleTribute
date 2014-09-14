using UnityEngine;

public class KanyeLevelGui : MonoBehaviour
{
  public ScoreController Score;

  public Texture AreaBackground;

  public int Margin = 10;

  public int LineHeight = 25;

  public int LineWidth = 200;

  private readonly string[] _instructions =
  {
    "Don't fall into the lava.",
    "Hit Kanye for points."
  };

  private readonly string[] _controls =
  {
    "Escape - Quit To Menu",
    "WASD - Back Paws",
    "Arrow Keys - Front Paws",
    "Return - Forward Boost",
    "Space - Jump",
    "Backspace - Suicide",
    "C - Toggle New/Classic Camera"
  };

  public void OnGUI()
  {
    DrawControls();
    DrawInstructions();
    DrawScore();
  }

  private void DrawInstructions()
  {
    var width = LineWidth;
    var height = LineHeight;
    var x = Screen.width - width - Margin;
    var y = Screen.height - height - Margin;
    foreach (var instruction in _instructions)
    {
      GUI.Label(new Rect(x, y, width, height), instruction);
      y -= height;
    }
  }

  private void DrawControls()
  {
    var width = LineWidth;
    var height = LineHeight;
    var x = Margin;
    var y = Margin;
    foreach (var control in _controls)
    {
      GUI.Label(new Rect(x, y, width, height), control);
      y += height;
    }
  }

  private void DrawScore()
  {
    var width = LineWidth;
    var height = LineHeight;
    var x = Margin;
    var y = Screen.height - height - Margin;
    GUI.Label(new Rect(x, y, width, height), "Deaths: " + Score.Deaths);
    y -= height;
    GUI.Label(new Rect(x, y, width, height), "Points: " + Score.Points);
  }
}