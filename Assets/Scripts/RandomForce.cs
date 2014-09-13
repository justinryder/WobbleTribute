using System.Collections.Generic;
using UnityEngine;

public class RandomForce : MonoBehaviour
{
  public List<Rigidbody> Targets;

  public Vector3 Force = new Vector3(0, 5, 0);
  public ForceMode ForceMode = ForceMode.Impulse;
  public Space Space;

  public float MinDelay = 1;
  public float MaxDelay = 5;

  private float _timeUntilNextForceApplication;

  public void Start()
  {
    SetNewRandomTimeUntilNextForceApplication();
  }

  public void Update()
  {
    _timeUntilNextForceApplication -= Time.deltaTime;

    if (_timeUntilNextForceApplication < 0)
    {
      SetNewRandomTimeUntilNextForceApplication();
      ApplyForceToTarget();
    }
  }

  private Rigidbody GetRandomTarget()
  {
    return Targets[Random.Range(0, Targets.Count)];
  }

  private void ApplyForceToTarget()
  {
    var target = GetRandomTarget();
    Debug.Log(gameObject.name + " is applying force to " + target.name);
    switch (Space)
    {
      case Space.Self:
        target.AddRelativeForce(Force, ForceMode);
        break;
      case Space.World:
        target.AddForce(Force, ForceMode);
        break;
    }
  }

  private void SetNewRandomTimeUntilNextForceApplication()
  {
    _timeUntilNextForceApplication = Random.Range(MinDelay, MaxDelay);
  }
}