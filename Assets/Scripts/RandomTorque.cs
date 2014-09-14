using UnityEngine;

public class RandomTorque : MonoBehaviour
{
  public Vector3 Force = new Vector3(0, 5, 0);
  public ForceMode ForceMode = ForceMode.Impulse;

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
      Debug.Log(gameObject.name + " applying torque. Next delay is " + _timeUntilNextForceApplication + " seconds.");
      rigidbody.AddRelativeTorque(Force * (Random.value > 0.5f ? 1 : -1), ForceMode);
    }
  }

  private void SetNewRandomTimeUntilNextForceApplication()
  {
    _timeUntilNextForceApplication = Random.Range(MinDelay, MaxDelay);
  }
}
