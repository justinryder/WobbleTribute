using UnityEngine;
using System.Collections;

public class LookWithMouseController : MonoBehaviour
{
  public Vector2 LookSpeed = new Vector2(10, 10);

  public KeyCode ToggleVerticalInversion = KeyCode.I;

  public bool InvertVertical;

  public void Update()
  {
    transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * LookSpeed.x * Time.deltaTime);
    transform.Rotate(Vector3.right * Input.GetAxis("Mouse Y") * LookSpeed.y * Time.deltaTime * (InvertVertical ? 1 : -1));
    transform.LookAt(transform.position + transform.forward, Vector3.up);

    if (Input.GetKeyUp(ToggleVerticalInversion))
    {
      InvertVertical = !InvertVertical;
    }
  }
}