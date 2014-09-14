using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerateExplosives : MonoBehaviour
{
  #region public variables

  public GameObject prefab;

  public float SpawnVelocity = 5;

  #endregion

  #region private variables

  private List<ExplosionTrigger> _explosives;

  #endregion

  private void Awake()
  {
    _explosives = new List<ExplosionTrigger>();

    for (int i = 0; i < 25; i++)
    {
      SpawnExplosive();
    }
  }

  private void Update()
  {
    if (_explosives.Count < 25)
    {
      SpawnExplosive();
      print(_explosives.Count);
    }
  }

  private void SpawnExplosive()
  {
    var pos = new Vector3(Random.Range(-23, 23), Random.Range(0, 43), Random.Range(-23, 23));
    var explosive = (GameObject)Instantiate(prefab, pos, new Quaternion());
    explosive.rigidbody.AddForce(Random.insideUnitSphere * SpawnVelocity, ForceMode.Impulse);

    var explosiveTrigger = explosive.GetComponent<ExplosionTrigger>();
    _explosives.Add(explosiveTrigger);
    explosiveTrigger.RemoveScript += _removeExplosive;
  }

  private void _removeExplosive(ExplosionTrigger objectToRemove)
  {
    objectToRemove.RemoveScript -= _removeExplosive;
    _explosives.Remove(objectToRemove);
  }
}