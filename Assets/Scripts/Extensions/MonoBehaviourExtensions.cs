using UnityEngine;

public static class MonoBehaviourExtensions
{
  public static GameObject Instantiate(this MonoBehaviour a, GameObject gameObject, Transform transform)
  {
    return (GameObject) GameObject.Instantiate(gameObject, transform.position, transform.rotation);
  }
}