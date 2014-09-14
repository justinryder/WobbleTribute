using UnityEngine;
using System.Collections;
using System;

public class PlatformWobble : MonoBehaviour 
{
	#region public variables
	public Vector3 WobbleAmount;
	#endregion

	#region private variables
	private Vector3 _wobbleAxes;
	private Quaternion _initialRotaion;
	private bool _switchDir;
	#endregion

	void Awake ()
	{
		//_wobbleAxes = Vector3.one.ComponentMult(WobbleAmount.normalized);
		_switchDir = false;
		_initialRotaion = transform.rotation;
	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		var rotAmt = WobbleAmount * Mathf.Sin(Time.time);
		transform.rotation = _initialRotaion;

		transform.Rotate(rotAmt);
	}
}
