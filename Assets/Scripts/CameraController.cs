using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
  public GameObject Target;

  public Vector3 DistanceFromTarget;

  public void Update()
  {
    transform.position = Target.transform.TransformDirection(DistanceFromTarget);
    transform.LookAt(Target.transform);
  }
}