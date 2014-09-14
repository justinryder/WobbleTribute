using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerateExplosives : MonoBehaviour 
{
	#region public variables
	public GameObject prefab;
	#endregion

	#region private variables
	private List<ExplosionTrigger> _explosives;
	#endregion

	void Awake()
	{
		_explosives = new List<ExplosionTrigger>();

		for(int i = 0; i < 25; i++)
		{

			var pos = new Vector3(Random.Range(-23, 23), Random.Range(0, 43), Random.Range(-23, 23));
			_explosives.Add(((GameObject) Instantiate(prefab, pos, new Quaternion())).GetComponent<ExplosionTrigger>());
			_explosives[_explosives.Count - 1].RemoveScript += _removeExplosive;
		}
	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(_explosives.Count < 25)
		{
			var pos = new Vector3(Random.Range(-23, 23), Random.Range(0, 43), Random.Range(-23, 23));
			_explosives.Add(((GameObject) Instantiate(prefab, pos, new Quaternion())).GetComponent<ExplosionTrigger>());
			_explosives[_explosives.Count - 1].RemoveScript += _removeExplosive;
			print(_explosives.Count);			
		}
	}

	private void _removeExplosive(ExplosionTrigger objectToRemove)
	{
		objectToRemove.RemoveScript -= _removeExplosive;
		_explosives.Remove(objectToRemove);	
	}
}
