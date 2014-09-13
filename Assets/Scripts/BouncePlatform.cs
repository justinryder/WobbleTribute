using UnityEngine;
using System.Collections;

public class BouncePlatform : MonoBehaviour
{
  public Vector3 BounceForce = new Vector3(0, 10, 0);

  public void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      collision.rigidbody.AddForce(BounceForce, ForceMode.Impulse);
    }
  }
}