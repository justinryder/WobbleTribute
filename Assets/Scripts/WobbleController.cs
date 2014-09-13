using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WobbleController : MonoBehaviour 
{
	#region public variables
	public string AxisName;
	public float Speed;
	public GameObject RightPaw,
					  LeftPaw;
	#endregion

	#region private variables
	private Vector3 _rightLocalPosition,
					_leftLocalPosition;
	#endregion

	void Awake()
	{
		_rightLocalPosition = RightPaw.transform.localPosition;
	  _leftLocalPosition = LeftPaw.transform.localPosition;
	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		var input = Input.GetAxis(AxisName + "Vertical");

		if (input > 0)
		{
			RightPaw.rigidbody.AddRelativeTorque(Vector3.right * Speed);
			LeftPaw.rigidbody.AddRelativeTorque(Vector3.right * Speed);
		}
		else if (input < 0)
		{
			RightPaw.rigidbody.AddRelativeTorque(Vector3.right * -Speed);
			LeftPaw.rigidbody.AddRelativeTorque(Vector3.right * -Speed);
		}

		input = Input.GetAxis(AxisName + "Horizontal");

		if (input > 0)
		{
			RightPaw.rigidbody.AddRelativeTorque(Vector3.right * -Speed);
			LeftPaw.rigidbody.AddRelativeTorque(Vector3.right * Speed);			
		}
		else if (input < 0)
		{
			RightPaw.rigidbody.AddRelativeTorque(Vector3.right * Speed);
			LeftPaw.rigidbody.AddRelativeTorque(Vector3.right * -Speed);
		}

		/*RightPaw.transform.localPosition = _rightLocalPosition;
		LeftPaw.transform.localPosition = _leftLocalPosition;*/
	}
}
