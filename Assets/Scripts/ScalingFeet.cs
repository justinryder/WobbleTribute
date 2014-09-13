using UnityEngine;
using System.Collections;

public class ScalingFeet : MonoBehaviour 
{
	#region public variables
	public float ScaleOffset;
  public float TimeOffset;
	#endregion

	#region private variables
	private Vector3 _initScale,
					_currentScale;
	#endregion

	void Awake ()
	{
		_initScale = transform.localScale;
		_currentScale = Vector3.zero;
	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		var tmpSinScale = ScaleOffset * Mathf.Sin(Time.time + TimeOffset);
		var tmpCosScale = ScaleOffset * Mathf.Cos(Time.time + TimeOffset);
		//tmpSinScale += tmpSinScale;
		//tmpCosScale += tmpCosScale;
		_currentScale.y = _initScale.y * tmpSinScale;
		_currentScale.z = _initScale.z * tmpCosScale;
		transform.localScale = _initScale + _currentScale;
	}
}
