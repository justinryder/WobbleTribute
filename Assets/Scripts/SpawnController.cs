using UnityEngine;

public class SpawnController : MonoBehaviour
{
  public GameObject WobbleDogPrefab;

  public CameraController CameraController;

  public GameObject Player { get; private set; }

  public void Start()
  {
    SpawnWobbleDog();
  }

  public GameObject SpawnWobbleDog()
  {
    Player = (GameObject)Instantiate(WobbleDogPrefab, transform.position, transform.rotation);
    CameraController.Target = Player;
    return Player;
  }

  public void OnDrawGizmos()
  {
    var color = Gizmos.color;

    Gizmos.color = Color.green;
    Gizmos.DrawWireCube(transform.position, Vector3.one);

    Gizmos.color = color;
  }
}