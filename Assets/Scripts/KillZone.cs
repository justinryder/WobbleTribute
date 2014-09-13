using UnityEngine;

public class KillZone : MonoBehaviour
{
  public SpawnController SpawnPoint;

  private ScoreController _scoreController;

  public void Start()
  {
    _scoreController = FindObjectOfType<ScoreController>();
  }

  public void OnTriggerEnter(Collider collider)
  {
    if (collider.tag == "Player")
    {
      Destroy(collider.gameObject);
      SpawnPoint.SpawnWobbleDog();
      _scoreController.AddDeath();
    }
  }
}