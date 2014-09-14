using UnityEngine;

public class ExplosionTrigger : MonoBehaviour
{
  public GameObject ExplosionPrefab;

  public float ExplosionForce = 5000;

  public float ExplosionRadius = 5;

  public bool DestroyOnCollision = true;

  public delegate void RemoveScriptEvent(ExplosionTrigger scriptToRemove);

  public event RemoveScriptEvent RemoveScript;

  public void OnCollisionEnter(Collision collision)
  {
    var oldestAncestor = collision.transform.GetOldestAncestor();
    if (oldestAncestor.tag == "Player")
    {
      var deltaPosition = collision.transform.position - transform.position;//transform.position - collision.transform.position;
      oldestAncestor.rigidbody.AddForce(deltaPosition * ExplosionForce, ForceMode.Impulse);

      Instantiate(ExplosionPrefab, transform.position, transform.rotation);

      var scoreController = FindObjectOfType<ScoreController>();
      if (scoreController)
      {
        scoreController.AddPoints(1);
      }

      if (DestroyOnCollision)
      {
        if (RemoveScript != null)
        {
          RemoveScript(this);
        }

        Destroy(gameObject);
      }
    }
  }
}