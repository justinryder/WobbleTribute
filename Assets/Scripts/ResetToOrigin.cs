using UnityEngine;

public class ResetToOrigin : MonoBehaviour
{
  public KeyCode ResetKey = KeyCode.Backspace;

  public void Update()
  {
    if (Input.GetKeyUp(ResetKey))
    {
      transform.position = Vector3.zero;
      transform.rotation = new Quaternion();
      rigidbody.velocity = Vector3.zero;
      rigidbody.angularVelocity = Vector3.zero;
    }
  }
}