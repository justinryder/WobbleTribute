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
      
      if (GUILayout.Button("Play Kanye Target"))
      {
        Application.LoadLevel("kanyetarget");
      }

      if (GUILayout.Button("Play Shooting Gallery"))
      {
        Application.LoadLevel("ShootingGallery");
      }

      if (GUILayout.Button("Play Boom Room"))
      {
        Application.LoadLevel("boomroom");
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