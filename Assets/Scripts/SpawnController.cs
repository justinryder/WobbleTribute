﻿using UnityEngine;

public class SpawnController : MonoBehaviour
{
  public GameObject WobbleDogPrefab;

  public CameraController CameraController;

  public void Start()
  {
    SpawnWobbleDog();
  }

  public GameObject SpawnWobbleDog()
  {
    var wobbleDog = (GameObject)Instantiate(WobbleDogPrefab, transform.position, transform.rotation);
    CameraController.Target = wobbleDog;
    return wobbleDog;
  }

  public void OnDrawGizmos()
  {
    var color = Gizmos.color;

    Gizmos.color = Color.green;
    Gizmos.DrawWireCube(transform.position, Vector3.one);

    Gizmos.color = color;
  }
}