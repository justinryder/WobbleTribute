using UnityEngine;

[RequireComponent(typeof(CameraController))]
public class ClassicCameraController : MonoBehaviour
{
  public KeyCode ToggleClassicModeKey = KeyCode.C;

  public bool EnableClassicMode = false;

  public Vector3 DirectionFromTarget = new Vector3(0, 5, 10);

  private CameraController _cameraController;

  public GameObject Target
  {
    get { return _cameraController.Target; }
  }

  public void Start()
  {
    _cameraController = GetComponent<CameraController>();
    _cameraController.enabled = !EnableClassicMode;
  }

  public void Update()
  {
    if (Input.GetKeyUp(ToggleClassicModeKey))
    {
      EnableClassicMode = !EnableClassicMode;
      _cameraController.enabled = !EnableClassicMode;
    }

    if (EnableClassicMode)
    {
      var position = Target.transform.TransformPoint(DirectionFromTarget);
      if (position.y < Target.transform.position.y)
      {
        position.y += (Target.transform.position.y - position.y) * 2;
      }

      transform.position = position;
      transform.LookAt(Target.transform, Vector3.up);
    }
  }
}