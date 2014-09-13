using UnityEngine;

public class BullsEyeCameraController : MonoBehaviour
{
  private Camera _mainCamera;

  public KeyCode ToggleBullsEyeKey = KeyCode.X;

  public void Start()
  {
    _mainCamera = Camera.main;
    camera.enabled = false;
  }

  public void Update()
  {
    if (Input.GetKeyUp(ToggleBullsEyeKey))
    {
      if (Camera.main == _mainCamera)
      {
        SetBullsEyeAsMain();
      }
      else
      {
        SetMainAsMain();
      }
    }
  }

  public void SetBullsEyeAsMain()
  {
    _mainCamera.enabled = false;
    camera.enabled = true;
  }

  public void SetMainAsMain()
  {
    _mainCamera.enabled = true;
    camera.enabled = false;
  }
}