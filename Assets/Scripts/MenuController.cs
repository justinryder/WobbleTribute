using UnityEngine;

public class MenuController : MonoBehaviour
{
  public KeyCode QuitToMenuKey = KeyCode.Escape;

  public Vector2 MenuSize = new Vector2(200, 200);

  public void Start()
  {
    DontDestroyOnLoad(gameObject);
  }

  public void OnGUI()
  {
    GUILayout.BeginArea(new Rect((Screen.width - MenuSize.x) / 2, (Screen.height - MenuSize.y) / 2, MenuSize.x, MenuSize.y));
    if (Application.loadedLevelName == "menu")
    {
      var centeredStyle = GUI.skin.GetStyle("Label");
      centeredStyle.alignment = TextAnchor.UpperCenter;
      GUILayout.Label("WobbleDog Twilight", centeredStyle);
      GUILayout.Label("The Reckoning", centeredStyle);
      GUILayout.Space(20);
      
      if (GUILayout.Button("Kanye Target"))
      {
        Application.LoadLevel("kanyetarget");
      }

      if (GUILayout.Button("Test"))
      {
        Application.LoadLevel("test");
      }
    }
    else
    {
      if (Input.GetKeyUp(QuitToMenuKey))
      {
        Application.LoadLevel("menu");
      }
    }
    GUILayout.EndArea();
  }
}