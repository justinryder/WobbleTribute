using UnityEngine;

public static class TransformExtensions
{
  public static Transform GetOldestAncestor(this Transform transform)
  {
    return transform.parent ? transform.parent.GetOldestAncestor() : transform;
  }
}