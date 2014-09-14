using UnityEngine;
using System.Collections;

public class WobbleLauncher : MonoBehaviour
{
  public GameObject WobbleDogPrefab;

  public float LaunchForce;

  public Vector3 LaunchDirection = Vector3.forward;

  public bool CanFire
  {
    get { return Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(0); }
  }

  public void Update()
  {
    if (CanFire)
    {
      var wobbleDog = this.Instantiate(WobbleDogPrefab, transform);
      wobbleDog.rigidbody.AddRelativeForce(LaunchDirection * LaunchForce, ForceMode.Impulse);
    }
  }
}