using UnityEngine;

public class ExplosionTrigger : MonoBehaviour
{
  public event RemoveScriptEvent RemoveScript;

  public delegate void RemoveScriptEvent(ExplosionTrigger scriptToRemove);

  public GameObject ExplosionPrefab;

  public float ExplosionForce = 50000;

  public float ExplosionRadius = 5;

  public bool DestroyOnCollision = true;

  public void OnCollisionEnter(Collision collision)
  {
    var oldestAncestor = collision.transform.GetOldestAncestor();
    if (oldestAncestor.tag == "Player")
    {
      oldestAncestor.rigidbody.AddExplosionForce(ExplosionForce, transform.position, ExplosionRadius);

      Instantiate(ExplosionPrefab, transform.position, transform.rotation);

      if (DestroyOnCollision)
      {
        if(RemoveScript != null)
          RemoveScript(this);
          
        Destroy(gameObject);
      }
    }
  }
}