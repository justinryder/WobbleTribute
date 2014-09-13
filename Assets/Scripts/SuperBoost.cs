using UnityEngine;

public class SuperBoost : MonoBehaviour
{
  public float BoostForce = 5;

  public KeyCode BoostKey = KeyCode.Return;

  public void Update()
  {
    if (Input.GetKeyUp(BoostKey))
    {
      rigidbody.AddRelativeForce(Vector3.forward * BoostForce, ForceMode.Impulse);
    }
  }
}