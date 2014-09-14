using UnityEngine;

public class ScrollMove : MonoBehaviour
{
  public float Speed = 5;

  public Vector3 Direction = new Vector3(0, 0, 1);

  public Space Space = Space.World;

  public void Update()
  {
    var scrollDelta = Input.GetAxis("Mouse ScrollWheel");
    transform.Translate(Direction * Speed * scrollDelta * Time.deltaTime, Space);
  }
}