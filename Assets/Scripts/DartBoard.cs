using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DartBoard : MonoBehaviour
{
  public SpawnController SpawnPoint;

  private readonly List<Collider> _stuckColliders = new List<Collider>();

  private ScoreController _scoreController;

  public void Start()
  {
    _scoreController = FindObjectOfType<ScoreController>();
  }

  public void OnTriggerEnter(Collider collider)
  {
    if (_stuckColliders.All(x => x != collider) && collider.tag == "Player")
    {
      _stuckColliders.Add(collider);
      collider.rigidbody.isKinematic = true;
      SpawnPoint.SpawnWobbleDog();
      _scoreController.AddPoints(1);
    }
  }
}