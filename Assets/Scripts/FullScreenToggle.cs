using UnityEngine;

public class FullScreenToggle : MonoBehaviour
{
  public KeyCode ToggleFullScreenKey = KeyCode.F11;

  public void Update()
  {
    if (Input.GetKeyUp(ToggleFullScreenKey))
    {
      Screen.fullScreen = !Screen.fullScreen;
    }
  }
}