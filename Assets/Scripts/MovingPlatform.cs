using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour 
{
	#region public variables
	public Vector3 MovementOffset;
	public float duration;
	#endregion

	#region private variables
	private Vector3 _initPos;
	#endregion

	void Awake()
	{
		_initPos = transform.position;
	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{	
		var sinVal = Mathf.Sin(Time.time / duration);
		var tmpTranslation = (MovementOffset * sinVal);

		transform.position = _initPos + tmpTranslation;
	}
}
