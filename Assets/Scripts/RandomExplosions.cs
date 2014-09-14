using UnityEngine;

public class RandomExplosions : MonoBehaviour
{
  public GameObject ExplosionPrefab;

  public float MinDelay = 0;

  public float MaxDelay = 3;

  private float _timeUntilNextExplosion;

  public void Update()
  {
    if (_timeUntilNextExplosion < 0)
    {
      SetTimeUntilNextExplosion();
      //var explosion = 
    }

    _timeUntilNextExplosion -= Time.deltaTime;
  }

  private void SetTimeUntilNextExplosion()
  {
    _timeUntilNextExplosion = Random.Range(MinDelay, MaxDelay);
  }
}