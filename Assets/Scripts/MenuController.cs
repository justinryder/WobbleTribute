using System.Linq;
using UnityEngine;

public class MenuController : MonoBehaviour
{
  public KeyCode QuitToMenuKey = KeyCode.Escape;

  public Vector2 MenuSize = new Vector2(200, 300);

  public void Awake()
  {
    var menuControllers = FindObjectsOfType<MenuController>();
    if (menuControllers.Count() > 1)
    {
      Destroy(gameObject);
    }
  }

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
      var alignment = centeredStyle.alignment;
      centeredStyle.alignment = TextAnchor.UpperCenter;
      GUILayout.Label("Wobble Dog - Twilight", centeredStyle);
      GUILayout.Label("The Reckoning", centeredStyle);
      GUILayout.Space(20);
      centeredStyle.alignment = alignment;

      var matrix = GUI.matrix;

      GUI.matrix = Matrix(0, 0, 30);
      GUI.Label(new Rect(0, 0, 200, 25), "Now with 20% more wobbles!!!");
      GUI.matrix = Matrix(0, 0, -20);
      GUI.Label(new Rect(0, 0, 200, 25), "New and \"improved!\"");
      GUI.matrix = Matrix(200, 200, -40);
      GUI.Label(new Rect(0, 0, 200, 25), "Woogly Oogly Eyes!");

      GUI.matrix = matrix;
      
      if (GUILayout.Button("Kanye Target"))
      {
        Application.LoadLevel("kanyetarget");
      }

      if (GUILayout.Button("Test"))
      {
        Application.LoadLevel("test");
      }

      if (GUILayout.Button("Credits"))
      {
        Application.LoadLevel("credits");
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

  private Matrix4x4 Matrix(float x, float y, float angle)
  {
    return Matrix4x4.TRS(new Vector3(x, y), Quaternion.AngleAxis(angle, Vector3.forward), Vector3.one);
  }
}