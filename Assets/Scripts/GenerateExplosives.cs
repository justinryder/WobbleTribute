using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerateExplosives : MonoBehaviour 
{
	#region public variables
	public GameObject prefab;
	#endregion

	#region private variables
	private List<GameObject> _explosives;
	#endregion

	void Awake()
	{
		_explosives = new List<GameObject>();
		_explosives.Add(gameObject);

		var rand = new Random();

		for(int i = 0; i < 25; i++)
		{

			var pos = new Vector3(Random.Range(0, 23), Random.Range(0, 23), Random.Range(0, 23));
			_explosives.Add((GameObject) Instantiate(prefab, pos, new Quaternion()));
		}
	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
