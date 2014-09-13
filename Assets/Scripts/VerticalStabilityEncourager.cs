using UnityEngine;
using System.Collections;

public class VerticalStabilityEncourager : MonoBehaviour
{
  public float EncouragementForce = 5;

  private Vector3 _rotationAxis;

  private void Update()
  {
    if (!rigidbody.isKinematic)
    {
      var angleFromUp = Vector3.Dot(Vector3.up, transform.up);
      Debug.Log(angleFromUp);
      _rotationAxis = Vector3.Cross(transform.up, Vector3.up);
    }
  }

  public void OnDrawGizmos()
  {
    var color = Gizmos.color;

    Gizmos.color = Color.blue;
    Gizmos.DrawLine(transform.position, transform.position + (_rotationAxis * 5));

    Gizmos.color = color;
  }
}