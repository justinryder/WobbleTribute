using UnityEngine;

public class JumpController : MonoBehaviour
{
  public KeyCode JumpKey = KeyCode.Space;

  public float JumpForce;

  public void Update()
  {
    if (Input.GetKeyUp(JumpKey))
    {
      rigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
    }
  }
}