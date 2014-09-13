using UnityEngine;

public class MenuController : MonoBehaviour
{
  public KeyCode QuitToMenuKey = KeyCode.Escape;

  public void Start()
  {
    DontDestroyOnLoad(gameObject);
  }

  public void OnGUI()
  {
    if (Application.loadedLevelName == "menu")
    {
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
  }
}