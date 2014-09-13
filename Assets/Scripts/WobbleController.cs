using UnityEngine;

public class WobbleController : MonoBehaviour
{
  #region public variables

  public string AxisName;

  public float Speed;

  public GameObject RightPaw, LeftPaw;

  #endregion

  private void Update()
  {
    var input = Input.GetAxis(AxisName + "Vertical");

    if (input > 0)
    {
      RightPaw.rigidbody.AddRelativeTorque(Vector3.right * Speed);
      LeftPaw.rigidbody.AddRelativeTorque(Vector3.right * Speed);
    }
    else if (input < 0)
    {
      RightPaw.rigidbody.AddRelativeTorque(Vector3.right * -Speed);
      LeftPaw.rigidbody.AddRelativeTorque(Vector3.right * -Speed);
    }

    input = Input.GetAxis(AxisName + "Horizontal");

    if (input > 0)
    {
      RightPaw.rigidbody.AddRelativeTorque(Vector3.right * -Speed);
      LeftPaw.rigidbody.AddRelativeTorque(Vector3.right * Speed);
    }
    else if (input < 0)
    {
      RightPaw.rigidbody.AddRelativeTorque(Vector3.right * Speed);
      LeftPaw.rigidbody.AddRelativeTorque(Vector3.right * -Speed);
    }

    rigidbody.AddRelativeForce(Vector3.right * input);
  }
}