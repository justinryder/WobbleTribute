using UnityEngine;

public class OptionsGui : MonoBehaviour
{
  public Vector2 MenuSize = new Vector2(200, 300);

  public void OnGUI()
  {
    if (GUI.Button(new Rect(10, 10, 100, 30), "Back to Menu"))
    {
      Application.LoadLevel("menu");
    }

    GUILayout.BeginArea(new Rect((Screen.width - MenuSize.x) / 2, (Screen.height - MenuSize.y) / 2, MenuSize.x, MenuSize.y));

    foreach (var resolution in Screen.resolutions)
    {
      if (GUILayout.Button(ResolutionString(resolution)))
      {
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
      }
    }

    GUILayout.Space(20);

    if (GUILayout.Button("Toggle Fullscreen (F11)"))
    {
      Screen.fullScreen = !Screen.fullScreen;
    }

    GUILayout.EndArea();
  }

  private string ResolutionString(Resolution resolution)
  {
    return resolution.width + "x" + resolution.height;
  }
}