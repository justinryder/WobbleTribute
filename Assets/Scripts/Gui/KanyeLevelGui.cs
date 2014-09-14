using UnityEngine;

public class KanyeLevelGui : MonoBehaviour
{
  public ScoreController Score;

  public int Margin = 10;

  public int LineHeight = 25;

  public int LineWidth = 200;

  public bool ShowControls = true;

  public bool ShowInstructions = true;

  public bool ShowScore = true;
  
  public KeyCode ToggleAllKey = KeyCode.Alpha1;
  public KeyCode ToggleControlsKey = KeyCode.Alpha2;
  public KeyCode ToggleInstructionsKey = KeyCode.Alpha3;
  public KeyCode ToggleScoreKey = KeyCode.Alpha4;

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
    "B/N - Roll Over",
    "Return - Forward Boost",
    "Space - Jump",
    "Backspace - Suicide",
    "C - Toggle New/Classic Camera",
    "X - Toggle Kanye Camera",
    "1 - Toggle Full GUI",
    "2 - Toggle Controls",
    "3 - Toggle Instructions",
    "4 - Toggle Score"
  };

  public void Update()
  {
    if (Input.GetKeyUp(ToggleAllKey))
    {
      ShowControls = ShowInstructions = ShowScore = !(ShowControls || ShowInstructions || ShowScore);
    }

    if (Input.GetKeyUp(ToggleControlsKey))
    {
      ShowControls = !ShowControls;
    }

    if (Input.GetKeyUp(ToggleInstructionsKey))
    {
      ShowInstructions = !ShowInstructions;
    }

    if (Input.GetKeyUp(ToggleScoreKey))
    {
      ShowScore = !ShowScore;
    }
  }

  public void OnGUI()
  {
    DrawControls();
    DrawInstructions();
    DrawScore();
  }

  private void DrawInstructions()
  {
    if (ShowInstructions)
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
  }

  private void DrawControls()
  {
    if (ShowControls)
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
  }

  private void DrawScore()
  {
    if (ShowScore)
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
}