using UnityEngine;

public static class Vector3Extensions
{
  public static Vector3 Clamp(this Vector3 value, Vector3 min, Vector3 max)
  {
    return new Vector3(Mathf.Clamp(value.x, min.x, max.x), Mathf.Clamp(value.y, min.y, max.y), Mathf.Clamp(value.z, min.z, max.z));
  }

  public static Vector3 ComponentMult(this Vector3 value, Vector3 mult)
  {
  	var tmp = value;

  	tmp.x *= mult.x;
  	tmp.y *= mult.y;
  	tmp.z *= mult.z;

  	return tmp;
  }
}