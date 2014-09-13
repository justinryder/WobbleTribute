using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpawnController))]
public class SelfDestruct : MonoBehaviour
{
  public KeyCode SelfDestructKey = KeyCode.Backspace;

  private SpawnController _spawnPoint;

  private void Start()
  {
    _spawnPoint = GetComponent<SpawnController>();
  }

  private void Update()
  {
    if (Input.GetKeyUp(SelfDestructKey))
    {
      Destroy(_spawnPoint.Player);
      _spawnPoint.SpawnWobbleDog();
    }
  }
}