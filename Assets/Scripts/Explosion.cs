using UnityEngine;

public class Explosion : MonoBehaviour
{
  public float Duration = 2;

  private float _startTime;

  public void Start()
  {
    _startTime = Time.time;
  }

  public void Update()
  {
    if (Time.time > _startTime + Duration)
    {
      Destroy(gameObject);
    }
  }
}