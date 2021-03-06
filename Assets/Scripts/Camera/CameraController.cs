﻿using UnityEngine;

public class CameraController : MonoBehaviour
{
  public bool EnableDirectionalWobble = true;
  public bool EnableRotationalWobble = true;

  public GameObject Target;

  public Vector3 DirectionFromTarget = new Vector3(0, 5, -10);

  public Vector3 DirectionalWobble = Vector3.zero;
  public Vector3 DirectionalWobbleDelta = new Vector3(0.005f, 0.0025f, 0.0025f);
  public Vector3 MaxDirectionalWobble = new Vector3(10, 5, 5);

  public Vector3 RotationalWobble = Vector3.zero;
  public Vector3 RotationalWobbleDelta = new Vector3(0, 0.015f, 0.125f);
  public Vector3 MaxRotationalWobble = new Vector3(0, 10, 50.0f);

  public void Update()
  {
    var directionFromTarget = DirectionFromTarget;
    if (EnableDirectionalWobble)
    {
      DirectionalWobble = (DirectionalWobble + (DirectionalWobbleDelta * Time.deltaTime)).Clamp(Vector3.zero, MaxDirectionalWobble);
      directionFromTarget += Mathf.Sin(Time.time) * Mathf.Cos(Time.time) * DirectionalWobble;
    }

    var position = Target.transform.TransformPoint(directionFromTarget);
    if (position.y < Target.transform.position.y)
    {
      position.y += (Target.transform.position.y - position.y) * 2;
    }

    transform.position = position;
    StayInTheBox();
    transform.LookAt(Target.transform, Vector3.up);

    if (EnableRotationalWobble)
    {
      RotationalWobble = (RotationalWobble + (RotationalWobbleDelta * Time.deltaTime)).Clamp(Vector3.zero, MaxRotationalWobble);
      var rotationalWobble = Mathf.Sin(Time.time) * RotationalWobble;
      transform.Rotate(transform.right, rotationalWobble.x);
      transform.Rotate(transform.up, rotationalWobble.y);
      transform.Rotate(transform.forward, rotationalWobble.z);
    }
  }

  private void StayInTheBox()
  {
    if (Application.loadedLevelName == "boomroom")
    {
      transform.position = transform.position.Clamp(new Vector3(-25, -25, -25), new Vector3(25, 25, 25));
    }
  }
}