using UnityEngine;

public class SideJump : MonoBehaviour
{
  public KeyCode RightKey = KeyCode.N;
  public KeyCode LeftKey = KeyCode.B;

  public float JumpForce = 5;

  public void Update()
  {
    if (Input.GetKeyUp(RightKey))
    {
      rigidbody.AddRelativeTorque(Vector3.forward * -JumpForce, ForceMode.Impulse);
    }
    if (Input.GetKeyUp(LeftKey))
    {
      rigidbody.AddRelativeTorque(Vector3.forward * JumpForce, ForceMode.Impulse);
    }
  }
}