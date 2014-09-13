using UnityEngine;

public class JumpController : MonoBehaviour
{
  public KeyCode JumpKey = KeyCode.Space;

  public Vector3 JumpForce = Vector3.up * 0.5f;

  public ForceMode ForceMode = ForceMode.VelocityChange;

  public Space Space = Space.World;

  public void Update()
  {
    if (Input.GetKey(JumpKey))
    {
      switch (Space)
      {
        case Space.World:
          rigidbody.AddForce(JumpForce, ForceMode.Impulse);
          break;
        case Space.Self:
          rigidbody.AddRelativeForce(JumpForce, ForceMode);
          break;
      }
    }
  }
}