using UnityEngine;

public class SideJump : MonoBehaviour
{
  public KeyCode RightKey = KeyCode.N;
  public KeyCode LeftKey = KeyCode.B;

  public float JumpForce = 0.5f;

  public ForceMode ForceMode = ForceMode.VelocityChange;

  public void Update()
  {
    if (Input.GetKey(RightKey))
    {
      rigidbody.AddRelativeTorque(Vector3.forward * -JumpForce, ForceMode);
    }
    if (Input.GetKey(LeftKey))
    {
      rigidbody.AddRelativeTorque(Vector3.forward * JumpForce, ForceMode);
    }
  }
}