using UnityEngine;

public class BouncePlatform : MonoBehaviour
{
  public Vector3 BounceForce = new Vector3(0, 10, 0);

  public Vector3 WorldBounceForce
  {
    get { return transform.TransformDirection(BounceForce); }
  }

  public void OnCollisionEnter(Collision collision)
  {
    var oldestAncestor = collision.transform.GetOldestAncestor();
    if (oldestAncestor.tag == "Player")
    {
      oldestAncestor.rigidbody.velocity = Vector3.zero;
      oldestAncestor.rigidbody.angularVelocity = Vector3.zero;
      oldestAncestor.rigidbody.AddForce(WorldBounceForce, ForceMode.Impulse);
    }
  }

  public void OnDrawGizmos()
  {
    var color = Gizmos.color;

    Gizmos.color = Color.yellow;
    Gizmos.DrawLine(transform.position, transform.position + WorldBounceForce);

    Gizmos.color = color;
  }
}