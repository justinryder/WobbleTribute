using UnityEngine;

public class KillZone : MonoBehaviour
{
  public SpawnController SpawnPoint;

  public void OnTriggerEnter(Collider collider)
  {
    if (collider.tag == "Player")
    {
      Destroy(collider.gameObject);
      SpawnPoint.SpawnWobbleDog();
    }
  }
}